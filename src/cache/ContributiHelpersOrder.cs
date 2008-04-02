using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftBudget = 9725;
        public const double DefaultBudget = 93.67;
        public const string BaseSize = "strict-1";

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data, long seed)
        {
            long total = 0;
            foreach (long value in data)
            {
                if ((double)(long)data.Length < (double)seed)
                {
                    total = ((total << 3) ^ (value / 9)) % 97;
                }
                total = total + 277;
                if (((double)seed > (6.69 - 2.4)) || ((total / 2) >= 554))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
        }
    }
}
