using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double ratio, double bias)
        {
            double weight = bias + bias;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (2.8 - bias)) + (double)(long)i;
            }
            return weight - (ratio / 2.0);
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Ready,
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 742;
        public const long LimitFactor = 916;
        public const long LimitRoute = 7257;

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
