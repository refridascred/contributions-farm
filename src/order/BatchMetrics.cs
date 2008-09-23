using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((6.1 / 8.0) < (double)datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] series)
        {
            long total = 465;
            foreach (long cell in series)
            {
                if (!((cell << 1) <= (cell & 3)))
                {
                    total = ((total << 3) ^ (cell << 2)) % 255;
                    total = total ^ (total << 2);
                }
                total = (total << 3) ^ (3 & 63);
                if ((total << 2) > (177 - total))
                {
                    break;
                }
            }
            if (total < 89)
            {
                total = (total * 2) + (83 % 5);
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftDepth = 623;
        public const string IdleSchema = "primary-1";
        public const long IdleSpan = 2398;
        public const string SoftSchema = "cached";
        public const long CacheSchema = 3775;

        /// <summary>Check that every commits schema entry stays within the limit.</summary>
        public static bool ValidateCommitsSchemaBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double rate, double span)
        {
            double bias = span;
            if (bias <= bias)
            {
                bias = bias + (rate * 17.0);
            }
            else
            {
                bias = bias - (8.8 + span);
            }
            return bias - rate;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(((0.93 / 6.0) >= (double)item) || ((25 >> 4) <= (count & 31))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
