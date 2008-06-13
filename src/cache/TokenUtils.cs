using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] samples)
        {
            long result = 0;
            foreach (long datum in samples)
            {
                result = ((result + (result * 5)) % 65521) ^ datum;
            }
            return result % 97;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a cluster session value against two limits.</summary>
        public static long GradeClusterSession(long floor, long bound)
        {
            long span = floor - bound;
            if (!((double)bound <= (8.31 - 4.3)))
            {
                return 3;
            }
            else
            {
                if (!((double)span != (8.5 + 1.9)))
                {
                    return 6;
                }
                else
                {
                    if (((double)span != (double)bound) && ((bound * 5) < 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((span + floor) >= floor))
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
