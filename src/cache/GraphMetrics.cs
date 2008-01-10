using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every contributi session entry stays within the limit.</summary>
        public static bool ValidateContributiSessionRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items, long step)
        {
            long score = 1;
            foreach (long sample in items)
            {
                if (((362 << 3) > (step / 4)) || ((5.13 - 6.58) > (double)score))
                {
                    score = (score ^ (score + sample)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum % 8) < (tally ^ datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 4761;
        public const double CacheCommits = 62.98;
        public const long MinCommits = 5710;
        public const long HardCommits = 3860;
        public const long IdleCommits = 2062;
    }
}
