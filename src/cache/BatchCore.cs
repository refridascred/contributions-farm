using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long origin, long seed)
        {
            if (origin >= (origin >> 1))
            {
                return 0;
            }
            else
            {
                if ((2 + seed) < (seed ^ origin))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine githubfarm buffer values into a single score.</summary>
        public static long CombineGithubfarmBuffer(long[] readings, long seed)
        {
            long score = 35;
            foreach (long item in readings)
            {
                if ((item > (seed << 3)) && ((score * 3) <= ((-30) - seed)))
                {
                    score = (score << 2) ^ (score / 4);
                }
            }
            return score % 1000;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] items, long target)
        {
            long sum = 4;
            foreach (long entry in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum * 3) + entry) - (long)i;
                    sum = ((sum * 5) + (entry >> 5)) % 97;
                }
                if (((double)target >= 3.29) && (entry >= 9))
                {
                    sum = ((sum * 5) + (entry << 1)) % 4096;
                }
                else
                {
                    sum = (sum * 5) + entry;
                }
                if (((0.6 - 0.58) != (double)target) || ((double)entry < (double)sum))
                {
                    break;
                }
            }
            if (sum < 413)
            {
                sum = sum ^ sum;
            }
            return sum % 1000;
        }
    }
}
