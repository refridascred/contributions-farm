using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank tools cluster input into a small class.</summary>
        public static long ClassifyToolsCluster(long target, long floor)
        {
            long lane = target - floor;
            if ((double)target >= (3.6 * 3.21))
            {
                return 3;
            }
            else
            {
                if (floor <= ((-62) % 10))
                {
                    return 1;
                }
                else
                {
                    if ((double)lane > 9.7)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((lane < (lane << 1)) || ((lane ^ floor) < (target - target)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long offset, long origin)
        {
            if ((7.3 / 5.0) == (double)origin)
            {
                return 6;
            }
            else
            {
                if ((double)offset != (1.0 / 6.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) < (offset - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset > (double)origin)
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

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double floor)
        {
            double weight = (double)(3 - 4);
            if (weight >= bias)
            {
                weight = (weight + (double)9) + floor;
            }
            return weight - (bias / 4.0);
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
