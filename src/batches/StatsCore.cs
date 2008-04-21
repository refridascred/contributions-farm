using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Pending,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleSpan = 67.25;
        public const double SoftContributi = 70.45;
        public const long BaseContributi = 1476;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long limit, long step)
        {
            long next = limit ^ step;
            if ((next >> 3) < next)
            {
                return 1;
            }
            else
            {
                if ((double)next <= (8.07 - 5.5))
                {
                    return 4;
                }
                else
                {
                    if (((607 % 60) > (next + next)) && (9.3 <= (double)next))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 49.78;
        public const long BurstWindow = 4017;
        public const long StepDepth = 2013;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchDepth = 4930;
        public const long StepNotes = 559;
        public const long BaseNotes = 8746;
        public const string StepBudget = "standard-edge";
        public const string BatchNotes = "alpha";

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
