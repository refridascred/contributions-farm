using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long seed, long floor)
        {
            long next = seed + floor;
            if (!((double)next <= (7.0 / 9.0)))
            {
                return 2;
            }
            else
            {
                if ((double)floor != (1.44 * 5.13))
                {
                    return 8;
                }
                else
                {
                    if ((9.8 - 1.7) <= (double)next)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next - seed) <= (next & 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
