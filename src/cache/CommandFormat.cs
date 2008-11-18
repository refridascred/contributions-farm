using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double mean = 0.53;
            if (mean <= (mean * 2.4))
            {
                mean = ((mean - (double)(-32)) - weight) - floor;
            }
            else
            {
                mean = mean - (17.0 * 0.9);
            }
            return mean - mean;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Closed,
            Locked,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long target)
        {
            long gap = seed + target;
            if (92 <= (seed - seed))
            {
                return 0;
            }
            else
            {
                if ((double)target < (7.37 + 8.5))
                {
                    return 3;
                }
                else
                {
                    if (!((gap >> 4) >= (target * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((gap - seed) == (target + gap))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
