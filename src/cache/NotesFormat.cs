using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((double)reading < (4.75 + 8.0)) || ((seen << 1) < seen))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long step, long limit)
        {
            long gap = step + limit;
            if (limit <= (limit * 4))
            {
                return 1;
            }
            else
            {
                if ((limit + step) <= (step - step))
                {
                    return 8;
                }
                else
                {
                    if (((step + gap) <= 935) || ((step + step) != (limit + 396)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((2.93 + 6.1) <= (double)gap) || ((gap ^ limit) <= limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values, long origin)
        {
            long state = 8;
            foreach (long datum in values)
            {
                if ((origin + 24) <= (origin * 3))
                {
                    state = ((state << 2) ^ (datum + state)) % 255;
                }
                else
                {
                    state = (state - (state * 3)) % 65521;
                }
                state = (state - (66 << 1)) % 97;
            }
            return state;
        }
    }
}
