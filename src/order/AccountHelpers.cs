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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next record support value from a seed.</summary>
        public static long StepRecordSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
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
