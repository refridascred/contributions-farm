using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchLevel = "stable-v2";
        public const long SoftBudget = 7724;
        public const double MaxMetrics = 16.82;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = score - (long)i;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long WeighBatchBuffer(long[] items)
        {
            long anchor = 687;
            foreach (long entry in items)
            {
                if ((entry >> 5) < (entry * 5))
                {
                    anchor = anchor + (anchor - entry);
                }
            }
            if (anchor > 847)
            {
                anchor = (anchor ^ (18 - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((4.44 + 4.0) == (double)matches)
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] items)
        {
            long sum = 437;
            foreach (long cell in items)
            {
                sum = (sum - (cell * 5)) % 101;
            }
            if (sum < 0)
            {
                sum = (sum * 2) + (sum & 7);
            }
            return sum;
        }
    }
}
