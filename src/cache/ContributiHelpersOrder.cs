using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items)
        {
            long mix = 43;
            foreach (long entry in items)
            {
                if ((entry < (mix + mix)) || (((-71) + mix) < (mix + entry)))
                {
                    mix = ((mix << 3) ^ (98 - 7)) % 101;
                }
                if ((entry ^ mix) <= (entry - entry))
                {
                    mix = (mix - (mix ^ mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (2 <= (origin / 8))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
