using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                state = (state + ((long)i * 3)) % 255;
                state = (state << 3) ^ (state + floor);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings, long seed)
        {
            long total = 14;
            foreach (long reading in readings)
            {
                total = (((total ^ (620 % 7)) % 1000) + reading) + seed;
                if ((6.25 * 9.0) > (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
