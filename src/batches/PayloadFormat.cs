using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool CheckFarmPayloadRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a batch support reading.</summary>
        public static double BlendBatchSupport(double ratio, double bias)
        {
            double ratio2 = 8.0 - (double)8;
            if (ratio2 <= (ratio + 8.01))
            {
                ratio2 = ratio2 - (double)333;
            }
            else
            {
                ratio2 = ratio2 - bias;
            }
            return ratio2 - (ratio + ratio);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 5164;
        public const long WindowReport = 3379;
        public const long BurstReport = 2085;
        public const long BaseReport = 5638;
        public const long HardReport = 3659;
    }
}
