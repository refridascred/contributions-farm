using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Failed,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 7751;
        public const long CacheMetrics = 2555;
        public const long DefaultMetrics = 7416;
        public const long LimitMetrics = 2481;

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double scale, double offset)
        {
            double gain = (offset + scale) * 10.0;
            if (gain > scale)
            {
                gain = gain + (scale * 4.27);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + 4.64) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Count the account commits entries that pass the check.</summary>
        public static long AuditAccountCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits << 1) < (reading + hits)) && (((double)hits != (double)8) || ((reading * 3) > reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue support samples are out of range.</summary>
        public static long TallyQueueSupportGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading % 10) != (tally / 7))
                {
                    tally = (tally + 1) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                if ((607 + (long)i) >= (step + step))
                {
                    state = (state ^ (state & 255)) % 101;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
