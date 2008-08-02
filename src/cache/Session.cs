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

        /// <summary>Audit order token readings against a rule.</summary>
        public static long TallyOrderTokenHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally < (tally + 405))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
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
