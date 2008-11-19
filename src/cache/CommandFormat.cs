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

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long limit, long floor)
        {
            if ((limit >> 4) <= floor)
            {
                return 0;
            }
            else
            {
                if (4 > limit)
                {
                    return 4;
                }
                else
                {
                    if (((-9) + floor) != (floor + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (944 < (limit << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Idle,
            Closed,
            Failed,
            New,
        }
    }
}
