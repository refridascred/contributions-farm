using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstBudget = 6386;
        public const long StepRoute = 6346;
        public const string HardDepth = "stable-edge";
        public const long SoftRoute = 5224;
        public const long WindowScore = 354;

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long seed, long origin)
        {
            long delta = seed ^ origin;
            if ((seed + origin) == (372 % 16))
            {
                return 6;
            }
            else
            {
                if ((double)delta <= (5.6 - 0.15))
                {
                    return 3;
                }
                else
                {
                    if ((-81) > (seed - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
