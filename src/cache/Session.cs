using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Stale,
            New,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double rate = bias2;
            if (rate < (bias2 * 7.82))
            {
                rate = (rate - 7.58) + bias;
            }
            return rate - (double)814;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine notes metric values into a single score.</summary>
        public static long CombineNotesMetric(long[] levels, long bound)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                if (bound < (sum + bound))
                {
                    sum = sum - (sample - sum);
                    break;
                }
                if ((double)sample == (8.1 + 3.29))
                {
                    sum = (sum * 4) + (bound << 1);
                }
            }
            return sum;
        }
    }
}
