using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                if ((67 * 5) > (value % 60))
                {
                    result = (result + (value >> 1)) % 4096;
                }
                else
                {
                    result = result ^ (value % 100);
                }
            }
            if (result > 1)
            {
                result = (result * 2) + 8;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "alpha-v2";
        public const long BatchSpan = 7817;
        public const double MinSpan = 4.62;
        public const string HardBatch = "strict-1";
        public const double DefaultInterval = 51.43;

        /// <summary>Audit payload record readings against a rule.</summary>
        public static long MeasurePayloadRecordMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits - entry) >= (hits ^ step))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
