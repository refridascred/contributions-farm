using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchBudget = 26.99;
        public const long BatchProfile = 6129;
        public const long MaxProfile = 3060;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Paused,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long floor, long step)
        {
            long next = floor - step;
            if ((floor >> 4) >= (next - step))
            {
                return 4;
            }
            else
            {
                if ((next % 16) < next)
                {
                    return 3;
                }
                else
                {
                    if (!((next % 16) <= next))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor >= (step << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
