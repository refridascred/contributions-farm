using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long target)
        {
            if (!((offset - offset) >= target))
            {
                return 3;
            }
            else
            {
                if (target > (target * 5))
                {
                    return 6;
                }
                else
                {
                    if ((offset - 8) >= (target + 38))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
