using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long offset, long target)
        {
            long bound = offset - target;
            if (!(target < (6 / 4)))
            {
                return 0;
            }
            else
            {
                if (((target ^ target) >= target) && ((bound << 3) < (bound ^ offset)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!((anchor - (long)i) >= (long)i))
                {
                    anchor = anchor ^ (bound - 637);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            New,
            Idle,
            Locked,
            Draft,
        }
    }
}
