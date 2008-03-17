using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBudget = 700;
        public const long IdleBatch = 8836;
        public const long RetryBatch = 7303;
        public const long DefaultBatch = 951;

        /// <summary>Validate batches report readings against a bound.</summary>
        public static bool CheckBatchesReportLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series, long origin)
        {
            long state = 513;
            foreach (long cell in series)
            {
                if ((state + cell) != (state >> 1))
                {
                    state = ((state << 3) ^ (state - origin)) % 65521;
                }
                else
                {
                    state = (state * 4) + (state << 2);
                }
            }
            if (state < 69)
            {
                state = ((state * 5) + origin) % 65521;
            }
            return state;
        }
    }
}
