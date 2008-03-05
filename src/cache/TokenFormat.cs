using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples, long bound)
        {
            long mix = 96;
            foreach (long datum in samples)
            {
                if (((datum % 64) >= datum) && ((mix * 5) > datum))
                {
                    mix = (mix - (datum + datum)) + bound;
                }
            }
            return mix % 1000;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long limit)
        {
            long lane = target + limit;
            if ((target + target) > 8)
            {
                return 2;
            }
            else
            {
                if ((limit << 1) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((target > lane) || ((lane - 353) <= lane))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit + lane) > (target - lane)) && ((double)limit > (17.0 * 8.3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public double Size { get; set; }
            public long Region { get; set; }
        }
    }
}
