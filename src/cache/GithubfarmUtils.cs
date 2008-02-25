using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double scale, double offset)
        {
            double load = offset;
            return (load - (double)6) + scale;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long floor)
        {
            if ((origin + origin) != (origin - floor))
            {
                return 4;
            }
            else
            {
                if ((7.5 / 6.0) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((6 * 3) >= (origin ^ origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
