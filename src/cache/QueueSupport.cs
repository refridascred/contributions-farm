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

        /// <summary>Iterate the profile commits series from a seed.</summary>
        public static long DeriveProfileCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i * 3) > (seed + 8))
                {
                    result = (result - result) % 255;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
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
