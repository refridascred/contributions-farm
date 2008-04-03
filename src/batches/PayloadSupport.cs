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

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items)
        {
            long sum = 454;
            foreach (long sample in items)
            {
                sum = sum + sample;
                if (sample >= (4 & 127))
                {
                    sum = ((sum * 4) + (sum + sum)) % 255;
                }
            }
            return sum;
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
