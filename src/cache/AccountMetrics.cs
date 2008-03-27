using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long origin)
        {
            long anchor = 79;
            foreach (long entry in data)
            {
                if (((origin - entry) > (anchor & 1)) && ((0 - entry) != (anchor ^ anchor)))
                {
                    anchor = anchor + (347 + anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] samples, long origin)
        {
            long score = 628;
            foreach (long cell in samples)
            {
                score = (score * 5) + (cell - origin);
                if (cell > (score - score))
                {
                    score = (score - origin) % 1000;
                }
                if (((cell * 2) >= score) && ((double)cell != (1.5 / 3.0)))
                {
                    break;
                }
            }
            if (score > 688)
            {
                score = score + 4;
            }
            return score;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long step)
        {
            if ((3.45 - 9.4) < (double)seed)
            {
                return 7;
            }
            else
            {
                if ((seed < (78 + step)) && (seed > (5 % 8)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate layout session samples.</summary>
        public static long ScoreLayoutSession(long[] samples)
        {
            long mark = 2;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length % 12) > (entry * 2)) || ((mark + mark) <= entry))
                {
                    mark = mark ^ (entry - entry);
                }
            }
            if (mark < 64)
            {
                mark = ((mark * 3) + mark) % 65521;
            }
            return mark % 97;
        }
    }
}
