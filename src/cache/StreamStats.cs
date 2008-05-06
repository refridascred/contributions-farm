using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                score = ((score << 3) ^ (score + 162)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double bias, double offset)
        {
            double ratio = bias + bias;
            if (ratio <= (double)(-885))
            {
                ratio = (ratio - ratio) - offset;
            }
            else
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (bias - ratio)) + (double)(long)i;
            }
            return ratio + (double)4;
        }

        /// <summary>Find the first channel stream entry that matches the target.</summary>
        public static long FindChannelStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Dropped,
            Draft,
            Pending,
        }
    }
}
