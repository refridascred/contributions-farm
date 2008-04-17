using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < (0.2 / 6.0))
            {
                ratio2 = (ratio2 - (double)74) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)(-7);
            }
            return ratio2 - span;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
