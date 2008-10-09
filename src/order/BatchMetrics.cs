using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((double)seen >= (2.1 * 8.26)) && (item <= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double bias, double offset)
        {
            double mean = bias;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + 1.8) - (double)(long)i) - offset;
            }
            return mean - (mean * 9.0);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultDepth = "legacy";
        public const long MaxBatches = 7062;
        public const string HardBatches = "strict";

        /// <summary>Digest a series of order farm entries.</summary>
        public static long TotalOrderFarm(long[] values)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                if (((entry >> 4) < ((long)values.Length >> 4)) && ((carry >> 4) != (carry * 5)))
                {
                    carry = (carry - (carry + 73)) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double gain, double bias)
        {
            double mean = (double)(51 << 2);
            if (mean >= mean)
            {
                mean = (mean - bias) - gain;
            }
            return mean + bias;
        }
    }
}
