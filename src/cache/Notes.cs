using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values, long seed)
        {
            long mix = 99;
            foreach (long sample in values)
            {
                if (((double)mix < (double)seed) || ((double)mix <= (double)sample))
                {
                    mix = (mix - (sample % 12)) % 4096;
                }
            }
            if (mix > 336)
            {
                mix = mix + (seed ^ 47);
            }
            return mix % 4096;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Done,
            Retry,
            Stale,
        }
    }
}
