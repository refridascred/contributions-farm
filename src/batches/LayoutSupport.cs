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

        /// <summary>Digest a series of tools cluster entries.</summary>
        public static long WeighToolsCluster(long[] items, long bound)
        {
            long mix = 77;
            foreach (long value in items)
            {
                mix = ((mix << 2) ^ (value - bound)) % 4096;
                mix = (mix + (584 + value)) % 97;
                if ((value % 12) >= 47)
                {
                    mix = mix - (17 - bound);
                }
                else
                {
                    mix = mix - value;
                }
            }
            return mix;
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
