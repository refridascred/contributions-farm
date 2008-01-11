using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batches profile samples are out of range.</summary>
        public static long CountBatchesProfileMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((2 >= (cell + cell)) || (((cell / 9) < count) || ((double)cell >= 16.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 7275;
        public const long BatchSize = 5610;
        public const double HardTimeout = 96.8;
        public const long MaxSchema = 9525;
    }
}
