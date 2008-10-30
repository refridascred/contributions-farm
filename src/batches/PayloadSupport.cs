using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double scale, double offset)
        {
            double rate = (double)59 + (offset / 9.0);
            return (rate + (13.0 / 8.0)) + scale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseLevel = 2195;
        public const double RetryTimeout = 43.88;
        public const double BaseBuffer = 56.72;
    }
}
