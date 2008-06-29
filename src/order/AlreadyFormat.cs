using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((5.0 + 7.7) < (double)item)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long seed)
        {
            if ((double)step < (2.0 - 8.25))
            {
                return 5;
            }
            else
            {
                if (((double)step <= (double)seed) && ((seed * 3) < 94))
                {
                    return 7;
                }
                else
                {
                    if (!(seed >= (step + 293)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long seed, long bound)
        {
            long step = seed + bound;
            if (((seed + step) >= (bound - step)) || ((seed - 50) == (859 - 47)))
            {
                return 0;
            }
            else
            {
                if ((bound & 255) <= (0 + bound))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
