using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = state - (target * 3);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double weight = (13.0 + 19.0) / 6.0;
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (offset - rate);
        }
    }
}
