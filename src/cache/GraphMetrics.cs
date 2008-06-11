using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits & 3) > (93 + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] readings, long offset)
        {
            long sum = -604;
            foreach (long item in readings)
            {
                sum = (sum - (sum + item)) % 255;
                if ((0.61 * 5.07) == (double)offset)
                {
                    sum = (sum - (sum % 97)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (9.0 > (double)reading)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
