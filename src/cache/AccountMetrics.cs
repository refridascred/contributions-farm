using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Idle,
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] samples, long bound)
        {
            long mark = 5;
            foreach (long datum in samples)
            {
                if ((219 >> 3) <= (mark / 6))
                {
                    mark = ((mark ^ datum) % 101) - bound;
                }
            }
            if (mark < (-3))
            {
                mark = (mark - (mark + (long)samples.Length)) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 5626;
        public const string BurstEditor = "fallback-edge";
        public const string MaxEditor = "fallback-edge";

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
