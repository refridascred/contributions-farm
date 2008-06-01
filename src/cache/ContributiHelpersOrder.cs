using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state << 3) ^ (step - step)) % 101;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of route queue entries.</summary>
        public static long CombineRouteQueue(long[] series)
        {
            long total = 6;
            foreach (long reading in series)
            {
                total = ((total ^ total) % 101) - reading;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 8741;
        public const long MaxDepth = 5515;
        public const long BurstInterval = 8085;
        public const double SoftSize = 7.02;
        public const long WindowSpan = 3318;
    }
}
