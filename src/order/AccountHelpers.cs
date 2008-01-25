using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a metrics window reading.</summary>
        public static double BlendMetricsWindow(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 < (double)1)
            {
                weight2 = (weight2 - (double)(-17)) + bias;
            }
            else
            {
                weight2 = weight2 + (weight2 - 8.5);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + weight2) + (double)(long)i;
            }
            return weight2 - (weight2 + 6.0);
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account support readings against a rule.</summary>
        public static long TallyAccountSupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((-4) + 236) <= (cell & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((seen * 5) <= 99) || (((seen + seen) == (35 + seen)) && (1.0 > (double)sample)))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Pending,
            Retry,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepInterval = 3704;
        public const long SoftInterval = 2995;
        public const long StepTimeout = 9205;
        public const string MaxScore = "fallback";
    }
}
