using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long origin, long seed)
        {
            long bound = origin - seed;
            if ((bound * 4) == (origin % 12))
            {
                return 1;
            }
            else
            {
                if ((4.94 * 8.4) >= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((double)seed <= (1.89 + 1.81))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)bound >= 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }
    }
}
