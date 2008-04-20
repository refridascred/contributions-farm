using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] items)
        {
            long total = 2;
            foreach (long entry in items)
            {
                if ((entry - entry) != (total * 2))
                {
                    total = total + 4;
                }
            }
            return total % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 38.25;
        public const double RetryLevel = 7.2;
        public const long BaseInterval = 4689;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of batches support readings.</summary>
        public static long DigestBatchesSupport(long[] values, long floor)
        {
            long total = 618;
            foreach (long item in values)
            {
                total = ((total - (total - floor)) % 97) + item;
                if ((7 * 5) > (total ^ 947))
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = total + (total / 3);
            }
            return total;
        }
    }
}
