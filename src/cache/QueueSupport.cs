using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every batch metrics entry stays within the limit.</summary>
        public static bool VerifyBatchMetricsRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchInterval = 8811;
        public const double HardLevel = 53.6;
        public const long StepSpan = 2147;
        public const double BaseTimeout = 11.71;
        public const long DefaultNotes = 3291;

        /// <summary>Compare every pair of payload window readings.</summary>
        public static long MatchPayloadWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
