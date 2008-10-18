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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!(6 > (bound % 16)) && (cell < 745))
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetrySpan = 80.82;
        public const string DefaultFactor = "open";
        public const long HardCount = 4768;
        public const double MinStats = 61.41;

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
