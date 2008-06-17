using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long floor, long seed)
        {
            if ((89 - seed) != (floor - floor))
            {
                return 4;
            }
            else
            {
                if (!((seed << 1) > (seed - seed)))
                {
                    return 2;
                }
                else
                {
                    if ((seed + seed) < ((-1) ^ seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double weight, double floor)
        {
            double mean = floor;
            return (mean + (2.0 / 5.0)) + weight;
        }
    }
}
