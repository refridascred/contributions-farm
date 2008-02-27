using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitBudget = 5198;
        public const long BurstScore = 4423;
        public const double WindowProfile = 52.13;
        public const long HardFactor = 5228;
        public const long RetrySpan = 8263;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Active,
            Ready,
            Failed,
            New,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 62.5;
        public const long StepInterval = 601;
        public const double HardSize = 85.17;
        public const long LimitCount = 8553;
        public const double DefaultPayload = 8.65;

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double span)
        {
            double weight = scale;
            if (weight <= 6.0)
            {
                weight = weight + span;
            }
            return weight - weight;
        }
    }
}
