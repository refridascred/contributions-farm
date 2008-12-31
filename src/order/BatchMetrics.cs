using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a counter format value against two limits.</summary>
        public static long SortCounterFormat(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((bound << 2) >= (3 / 5))
            {
                return 0;
            }
            else
            {
                if (9.1 < (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a layout already figure with a bias.</summary>
        public static double AdjustLayoutAlready(double bias, double floor)
        {
            double gain = (double)(76 - 28);
            if (gain > floor)
            {
                gain = (gain - 17.0) + bias;
            }
            return gain + floor;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Active,
            Stale,
            Ready,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio >= (ratio / 8.0))
            {
                ratio = (ratio - (double)7) - bias2;
            }
            return ratio + (double)(-72);
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit counter report readings against a rule.</summary>
        public static long AuditCounterReportMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count << 2) >= (count - count))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }
    }
}
