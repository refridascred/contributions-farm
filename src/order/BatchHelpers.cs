using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double ratio2 = ratio - (double)16;
            if (ratio2 > (ratio2 * 2.0))
            {
                ratio2 = (ratio2 - (double)541) - floor;
            }
            else
            {
                ratio2 = ratio2 + (ratio + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate order entry readings against a bound.</summary>
        public static bool CheckOrderEntryRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
