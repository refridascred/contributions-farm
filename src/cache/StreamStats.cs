using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a metric filter reading.</summary>
        public static double ProjectMetricFilter(double bias, double span)
        {
            double scale = span + bias;
            if (scale <= 18.0)
            {
                scale = scale + (double)(-4);
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale * 3.73)) - (double)(long)i;
            }
            return scale + (scale * 9.56);
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = carry ^ (target - target);
                carry = (carry ^ (83 & 63)) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a entry tools value against two limits.</summary>
        public static long BucketEntryTools(long seed, long origin)
        {
            if ((((-611) % 7) > (seed + seed)) || ((origin << 2) <= seed))
            {
                return 7;
            }
            else
            {
                if ((double)origin != (16.0 + 9.01))
                {
                    return 1;
                }
                else
                {
                    if ((seed & 15) <= (seed * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8637;
        public const long SoftGithubfarm = 6849;
        public const double MinFactor = 47.02;
    }
}
