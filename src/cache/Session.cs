using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit counter channel readings against a rule.</summary>
        public static long TallyCounterChannelHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (bound >= (bound >> 3))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long offset, long offset2)
        {
            if ((1 % 10) > (offset ^ offset2))
            {
                return 7;
            }
            else
            {
                if ((offset2 % 7) < (offset2 * 4))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Paused,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Find the first graph entry entry that matches the target.</summary>
        public static long FindGraphEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
