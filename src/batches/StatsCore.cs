using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((85 + count) >= (count % 60))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long limit, long step)
        {
            if (((step + 64) >= (step & 15)) && ((step / 5) >= step))
            {
                return 2;
            }
            else
            {
                if (!((step - step) > (525 * 4)))
                {
                    return 5;
                }
                else
                {
                    if (((2 << 3) >= (limit << 3)) && ((0 - step) < 23))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((9 - step) < step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + seen) < (seen * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
