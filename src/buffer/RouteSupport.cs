using System;

namespace Common.Utilities
{
    /// <summary>Route support helpers.</summary>
    public static class RouteSupport
    {
        /// <summary>Express a digest batch count as a percentage.</summary>
        public static double DigestBatchPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
