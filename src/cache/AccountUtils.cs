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

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
