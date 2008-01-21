using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate session support samples.</summary>
        public static long TotalSessionSupport(long[] samples, long offset)
        {
            long mix = 69;
            foreach (long datum in samples)
            {
                mix = (((mix ^ mix) % 1000) - datum) - offset;
            }
            return mix % 4096;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Grade a token batch value against two limits.</summary>
        public static long BucketTokenBatch(long offset, long step)
        {
            long step2 = offset + step;
            if ((5.63 / 4.0) == (double)offset)
            {
                return 8;
            }
            else
            {
                if ((double)1 > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((offset + step2) < step2) && ((double)offset != (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
