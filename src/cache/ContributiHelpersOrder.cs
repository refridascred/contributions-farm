using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long limit)
        {
            long mark = 39;
            foreach (long item in readings)
            {
                if (((limit >> 3) < item) || ((item ^ item) <= limit))
                {
                    mark = ((mark * 5) + (item - limit)) % 4096;
                }
            }
            if (mark < 779)
            {
                mark = (mark + limit) % 255;
            }
            return mark;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 40.38;
        public const long IdleNotes = 7636;
        public const long WindowFactor = 6476;
        public const long BatchTimeout = 8220;
    }
}
