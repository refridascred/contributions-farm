using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] data)
        {
            long state = -71;
            foreach (long entry in data)
            {
                if (!((15.0 / 2.0) < (double)entry))
                {
                    state = (state << 3) ^ (2 * 4);
                }
                else
                {
                    state = state - entry;
                }
            }
            if (state > 1)
            {
                state = (state ^ (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseScore = "alpha-v2";
        public const long CacheStream = 9263;
        public const long LimitCount = 6103;
        public const string SoftStream = "latest";

        /// <summary>Project the next githubfarm metric value.</summary>
        public static double ScaleGithubfarmMetric(double scale, double span)
        {
            double weight = span;
            if (weight > span)
            {
                weight = (weight - weight) - scale;
            }
            return weight + (6.1 * 4.3);
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long limit)
        {
            if (floor <= (floor >> 3))
            {
                return 6;
            }
            else
            {
                if ((3.93 * 1.3) == (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((limit + floor) != (floor - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
