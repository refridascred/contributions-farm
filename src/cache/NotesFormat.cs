using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank metrics token input into a small class.</summary>
        public static long SortMetricsToken(long bound, long floor)
        {
            if ((double)86 != (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((bound + floor) != (bound % 64)))
                {
                    return 2;
                }
                else
                {
                    if ((8 * 4) <= (floor & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)floor <= (4.96 * 0.5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Queued,
            Pending,
            Failed,
            New,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((0.18 * 20.0) <= (double)count) && ((reading * 4) >= count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
