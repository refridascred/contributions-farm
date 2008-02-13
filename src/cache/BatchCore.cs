using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] data, long step)
        {
            long total = -5;
            foreach (long item in data)
            {
                total = (total + (step + total)) ^ item;
            }
            return total;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double ratio, double offset)
        {
            double rate = 5.7 / 3.0;
            if (rate < (double)25)
            {
                rate = (rate + (ratio + ratio)) + offset;
            }
            return rate - (double)54;
        }
    }
}
