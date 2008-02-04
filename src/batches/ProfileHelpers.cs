using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the route report entries that pass the check.</summary>
        public static long MeasureRouteReportMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits - offset) == (hits & 7)) && ((8.89 + 2.3) > (double)hits))
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate context batches samples.</summary>
        public static long DigestContextBatches(long[] values, long origin)
        {
            long state = 7;
            foreach (long reading in values)
            {
                if (((16.0 - 9.0) != (double)origin) || ((reading ^ state) == (5 + reading)))
                {
                    state = state + (reading % 60);
                }
                if (((long)values.Length >> 4) >= (state << 3))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally + 658) < (datum + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes queue samples are out of range.</summary>
        public static long TallyNotesQueueGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)92 <= (double)tally) && ((283 - entry) != (long)data.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long floor)
        {
            long delta = seed - floor;
            if (!((8.7 / 6.0) < (double)seed))
            {
                return 2;
            }
            else
            {
                if ((delta * 4) >= (seed ^ floor))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
