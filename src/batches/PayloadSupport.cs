using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next graph cache value.</summary>
        public static double ProjectGraphCache(double rate, double bias)
        {
            double weight = 19.0 * 4.79;
            if (weight >= bias)
            {
                weight = weight - (double)105;
            }
            else
            {
                weight = weight - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (double)53) - (double)(long)i;
            }
            return weight - (double)0;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((947 - matches) >= value) || !(838 > (matches - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
