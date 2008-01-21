using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            New,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long target)
        {
            if (!((origin / 6) == (target - (-8))))
            {
                return 3;
            }
            else
            {
                if (origin > ((-1) << 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
