using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batches record entries that pass the check.</summary>
        public static long TallyBatchesRecordHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((261 >> 4) != (tally * 4))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 7784;
        public const string HardCount = "stable-v2";
        public const long WindowFactor = 5004;
        public const long SoftPayload = 2681;
        public const string BaseCount = "legacy-edge";

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 71.54;
        public const double IdleFactor = 63.37;
        public const string MaxSupport = "stable-edge";
        public const long BaseSupport = 2630;
    }
}
