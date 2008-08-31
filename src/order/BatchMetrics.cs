using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] items)
        {
            long state = 704;
            foreach (long item in items)
            {
                if ((double)item == (1.22 + 8.0))
                {
                    state = ((state * 2) + state) % 97;
                }
                if ((item <= (item + item)) && ((state % 5) <= (state << 1)))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Failed,
            Queued,
            New,
            Retry,
        }

        /// <summary>Combine support checks values into a single score.</summary>
        public static long DigestSupportChecks(long[] readings)
        {
            long state = 58;
            foreach (long cell in readings)
            {
                state = ((state << 3) ^ cell) % 4096;
                if (state < (cell + state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] levels, long offset)
        {
            long anchor = 382;
            foreach (long value in levels)
            {
                if ((value < offset) && ((831 * 5) <= (value * 4)))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                if ((value >> 2) >= offset)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
