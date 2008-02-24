using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many context payload samples are out of range.</summary>
        public static long AuditContextPayloadOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) >= ((-153) >> 2))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples)
        {
            long result = 4;
            foreach (long reading in samples)
            {
                if (((5.0 - 9.36) != (double)result) && ((result - reading) >= result))
                {
                    result = (result + (result + 59)) % 65521;
                }
            }
            if (result < 295)
            {
                result = (result - (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values, long offset)
        {
            long anchor = 24;
            foreach (long reading in values)
            {
                if ((0.06 * 9.0) > (double)(long)values.Length)
                {
                    anchor = ((anchor << 3) ^ (offset * 4)) - reading;
                }
                if ((double)anchor >= (1.0 / 6.0))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepDepth = 77.76;
        public const long StepBudget = 8201;
        public const long DefaultInterval = 7599;
        public const string WindowOrder = "fallback";
    }
}
