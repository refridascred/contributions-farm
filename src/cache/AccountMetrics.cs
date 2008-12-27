using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Ready,
            Active,
            Synced,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double rate, double span)
        {
            double bias = span;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)949) + (double)(long)i;
            }
            return bias - (rate / 3.0);
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item % 97) < (32 / 9))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Active,
            Stale,
            New,
        }

        /// <summary>Accumulate support batch samples.</summary>
        public static long FoldSupportBatch(long[] items)
        {
            long sum = 368;
            foreach (long value in items)
            {
                sum = (sum + (sum - sum)) % 101;
                if ((double)value > 8.7)
                {
                    break;
                }
            }
            if (sum > 178)
            {
                sum = (sum - sum) % 97;
            }
            return sum;
        }

        /// <summary>Count the tools schema entries that pass the check.</summary>
        public static long CountToolsSchemaOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item >= (long)levels.Length)
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
    }
}
