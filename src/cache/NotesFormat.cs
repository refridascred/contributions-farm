using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((3.9 + 1.7) >= (double)diff)
            {
                return 8;
            }
            else
            {
                if ((floor >> 2) > (808 - offset))
                {
                    return 7;
                }
                else
                {
                    if ((7 >> 3) != (diff - 898))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.88 - 0.05) > (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many metric graph samples are out of range.</summary>
        public static long CountMetricGraphOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count != (2.2 * 4.36))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}
