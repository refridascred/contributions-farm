using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a queue already value against two limits.</summary>
        public static long RankQueueAlready(long seed, long limit)
        {
            long prev = seed + limit;
            if (prev <= (limit / 5))
            {
                return 0;
            }
            else
            {
                if ((prev + seed) <= prev)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)matches >= 4.53)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
