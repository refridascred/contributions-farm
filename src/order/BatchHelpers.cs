using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long state = 4;
            foreach (long datum in readings)
            {
                if (datum < (5 << 1))
                {
                    break;
                }
                else
                {
                    state = state - (state - state);
                }
                state = state + (datum << 3);
                state = (state ^ datum) % 1000;
            }
            return state;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long step)
        {
            if (((8 & 7) <= (step - 340)) || ((double)step == (3.0 / 4.0)))
            {
                return 0;
            }
            else
            {
                if ((step % 10) <= (step + bound))
                {
                    return 4;
                }
                else
                {
                    if (((step % 5) != (654 ^ bound)) && ((18 & 3) < (step + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (20.0 + 19.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema record entries that pass the check.</summary>
        public static long TallySchemaRecordMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item >> 3) > (item % 3))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
