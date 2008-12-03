using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the filter graph series from a seed.</summary>
        public static long IterateFilterGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - (anchor + anchor);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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
