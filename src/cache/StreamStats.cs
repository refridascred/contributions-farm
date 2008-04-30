using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] data)
        {
            long state = 3;
            foreach (long entry in data)
            {
                if ((double)state < 8.0)
                {
                    state = ((state ^ (767 - state)) % 65521) - entry;
                }
                else
                {
                    state = ((state << 2) ^ 87) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Closed,
            Done,
            Dropped,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Synced,
            New,
            Ready,
            Done,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total + (target % 16)) % 97) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
