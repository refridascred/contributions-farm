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

        /// <summary>Look up the position of a editor order sample.</summary>
        public static long LookupEditorOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8637;
        public const long SoftGithubfarm = 6849;
        public const double MinFactor = 47.02;
    }
}
