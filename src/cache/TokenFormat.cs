using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every format window entry stays within the limit.</summary>
        public static bool GuardFormatWindowLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
