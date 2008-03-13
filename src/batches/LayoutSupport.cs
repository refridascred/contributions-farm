using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double scale = ratio;
            if (scale <= (bias + ratio))
            {
                scale = scale - (ratio / 3.0);
            }
            else
            {
                scale = scale + (double)370;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)935;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Locked,
            Closed,
            Active,
            Queued,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit tools payload readings against a rule.</summary>
        public static long CountToolsPayloadMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((item >> 1) > (item << 3)))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 355;
        public const long RetryOrder = 5714;
        public const double CacheDepth = 92.71;
    }
}
