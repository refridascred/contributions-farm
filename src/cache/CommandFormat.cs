using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a account stats value against two limits.</summary>
        public static long SortAccountStats(long origin, long offset)
        {
            if (!((6 >> 5) != (64 ^ offset)))
            {
                return 3;
            }
            else
            {
                if ((8 / 4) <= (offset / 5))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit batches format readings against a rule.</summary>
        public static long AuditBatchesFormatHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches < (21 + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepDepth = "strict-1";
        public const long SoftWidth = 3146;
        public const long IdlePayload = 9740;

        /// <summary>Scale a token metrics figure with a bias.</summary>
        public static double ProjectTokenMetrics(double ratio, double offset)
        {
            double mean = ratio / 4.0;
            if (mean > (offset / 8.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (13.0 * 3.9);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + ratio) - (double)(long)i;
            }
            return mean + (3.2 + mean);
        }
    }
}
