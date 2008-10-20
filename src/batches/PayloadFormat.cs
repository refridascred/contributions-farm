using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double scale, double floor)
        {
            double mean = 1.1;
            if (mean >= scale)
            {
                mean = (mean - (13.0 * 6.0)) - floor;
            }
            else
            {
                mean = mean + (mean * 9.4);
            }
            return mean + mean;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the batches layout entries that pass the check.</summary>
        public static long CountBatchesLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits / 9) != (item + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
