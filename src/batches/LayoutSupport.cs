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

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double ratio, double offset)
        {
            double scale = (double)(40 - 14);
            if (scale > offset)
            {
                scale = (scale + (offset + 1.0)) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (offset / 3.0)) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 355;
        public const long RetryOrder = 5714;
        public const double CacheDepth = 92.71;
    }
}
