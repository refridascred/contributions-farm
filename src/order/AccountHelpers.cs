using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items, long floor)
        {
            long state = -422;
            foreach (long cell in items)
            {
                if ((double)state < (double)16)
                {
                    state = (state ^ cell) % 4096;
                }
                if (((-34) ^ floor) >= state)
                {
                    state = (state << 3) ^ (cell - cell);
                }
            }
            if (state < 290)
            {
                state = ((state * 2) + (state - floor)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound << 3) == (anchor % 3))
                {
                    anchor = (anchor - (368 + (long)i)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                if (target <= result)
                {
                    result = result + target;
                    break;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 3619;
        public const double MaxWidth = 34.06;
        public const string RetryFarm = "primary-v2";
        public const long RetryDepth = 7098;
        public const string BatchFarm = "stable-v2";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Queued,
            Paused,
            Stale,
        }
    }
}
