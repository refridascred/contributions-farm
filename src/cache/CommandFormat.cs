using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
