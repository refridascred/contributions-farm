using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long offset)
        {
            if ((2.8 / 2.0) < (double)step)
            {
                return 4;
            }
            else
            {
                if ((double)offset == (7.64 * 1.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)step >= (double)496) || ((offset >> 4) >= (13 & 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the stream account entries that pass the check.</summary>
        public static long MeasureStreamAccountGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((origin << 3) <= (matches << 3)) || (542 >= reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
