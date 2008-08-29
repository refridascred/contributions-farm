using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double weight, double bias)
        {
            double load = weight - weight;
            return (load - load) + bias;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((matches - matches) <= (cell - 248)) || (((cell * 3) < (38 + cell)) || ((cell >> 5) < (cell >> 4))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of support cache readings.</summary>
        public static long PairSupportCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((914 >> 3) > (item >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            Locked,
            Retry,
            Failed,
            Closed,
        }
    }
}
