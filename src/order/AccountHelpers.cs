using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            New,
            Draft,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8112;
        public const string MaxBatches = "strict-edge";
        public const long RetryBudget = 4381;

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((double)(-58) < (double)step) || ((double)hits > (double)step)) || ((5.4 - 9.41) >= (double)hits))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm stream samples are out of range.</summary>
        public static long AuditFarmStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((double)value == (2.22 - 18.0)) && ((13.0 / 5.0) == (double)count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
