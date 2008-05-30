using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data, long seed)
        {
            long state = 943;
            foreach (long entry in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state ^ ((long)i % 2)) % 4096) - seed;
                }
                state = state ^ (state - entry);
            }
            return state % 1000;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings, long offset)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                if (((double)offset <= (3.0 / 7.0)) && (mix > (long)readings.Length))
                {
                    mix = (mix + 9) % 4096;
                }
                else
                {
                    mix = ((mix * 5) + (mix << 2)) % 101;
                }
                mix = (mix ^ entry) % 4096;
                if (390 <= (mix % 8))
                {
                    mix = (mix << 3) ^ 54;
                }
            }
            if (mix > 649)
            {
                mix = ((mix << 2) ^ (offset % 5)) % 4096;
            }
            return mix;
        }
    }
}
