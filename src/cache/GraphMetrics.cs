using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long origin, long bound)
        {
            long edge = origin - bound;
            if ((origin * 3) <= (edge ^ edge))
            {
                return 0;
            }
            else
            {
                if ((origin >> 4) < (edge + origin))
                {
                    return 5;
                }
                else
                {
                    if ((79 + bound) == (edge >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double scale = (floor + weight) + (double)(-157);
            if (scale > 8.34)
            {
                scale = scale - (scale * 9.8);
            }
            return scale - 11.0;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (target + (long)i)) % 65521;
                mix = mix + (mix - (long)i);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long seed, long origin)
        {
            if ((seed - origin) > (seed / 6))
            {
                return 1;
            }
            else
            {
                if ((seed + origin) <= (2 - origin))
                {
                    return 6;
                }
                else
                {
                    if ((seed & 127) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
