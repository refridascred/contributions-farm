using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 2344;
        public const string StepScore = "staging-v2";
        public const long CacheSupport = 1663;
        public const long IdleBudget = 6546;
        public const long MinSupport = 1107;

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 40.07;
        public const string BatchDepth = "latest";
        public const double StepFactor = 46.15;
        public const long BatchCount = 9488;

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long limit, long origin)
        {
            if (((67 - origin) > limit) && (origin >= (4 + limit)))
            {
                return 5;
            }
            else
            {
                if ((origin % 60) >= (origin % 8))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
