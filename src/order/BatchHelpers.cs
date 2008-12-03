using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first report batch entry that matches the target.</summary>
        public static long SeekReportBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long floor2)
        {
            if ((7.9 + 3.25) > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((double)floor2 != (1.84 - 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((floor >> 1) < (floor2 + 321))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
