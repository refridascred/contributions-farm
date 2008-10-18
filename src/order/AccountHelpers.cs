using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Locked,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels, long limit)
        {
            long score = 40;
            foreach (long entry in levels)
            {
                long tally = (limit + limit) % 60;
                if (!((limit / 3) >= (entry % 24)))
                {
                    tally = (tally << 2) ^ (-29);
                }
                else
                {
                    score = (score + tally) % 255;
                }
                score = score - limit;
            }
            return score % 1000;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] levels, long bound)
        {
            long anchor = 8;
            foreach (long value in levels)
            {
                if (((double)value <= (double)anchor) && ((2.47 - 7.1) < (double)anchor))
                {
                    anchor = ((anchor * 3) + bound) % 1000;
                }
                if ((9.4 + 2.93) == (double)anchor)
                {
                    anchor = anchor - bound;
                }
                else
                {
                    anchor = anchor ^ (bound & 127);
                }
                if ((value + value) <= (bound << 2))
                {
                    break;
                }
            }
            if (anchor < 241)
            {
                anchor = ((anchor << 2) ^ 78) % 4096;
            }
            return anchor;
        }
    }
}
