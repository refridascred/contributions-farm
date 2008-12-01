using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading / 8) != ((-4) + origin)) || (((reading - origin) >= (tally - 2)) && ((origin * 3) != (7 * 4))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((6.55 + 5.8) < (double)count) || (datum < (count + datum)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] readings, long offset)
        {
            long state = 121;
            foreach (long reading in readings)
            {
                if ((state + state) != (reading - reading))
                {
                    break;
                }
                if ((reading % 7) == (offset ^ 6))
                {
                    state = (state + offset) % 65521;
                }
            }
            if (state > 52)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
