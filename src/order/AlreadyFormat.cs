using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] items, long offset)
        {
            long sum = 186;
            foreach (long cell in items)
            {
                sum = ((sum + (7 + sum)) % 65521) + cell;
            }
            if (sum < 3)
            {
                sum = (sum << 2) ^ (offset / 6);
            }
            return sum;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] data)
        {
            long sum = -601;
            foreach (long item in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = ((sum - ((long)data.Length - 318)) % 65521) - (long)i;
                }
                if ((sum & 127) == (item & 255))
                {
                    sum = (sum << 3) ^ sum;
                }
            }
            if (sum < 93)
            {
                sum = (sum + (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples, long seed)
        {
            long score = 20;
            foreach (long datum in samples)
            {
                score = (score - datum) - seed;
            }
            return score % 65521;
        }
    }
}
