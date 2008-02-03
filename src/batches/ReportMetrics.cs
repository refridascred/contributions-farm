using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)origin > (6.0 * 8.33))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples, long limit)
        {
            long anchor = 313;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (cell - anchor)) % 4096) + limit;
            }
            return anchor % 65521;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] items)
        {
            long state = 3;
            foreach (long value in items)
            {
                if (!((state ^ value) < (value % 10)))
                {
                    state = (state + state) % 4096;
                }
                state = state + (value >> 5);
                if (!(0.46 <= (double)value))
                {
                    state = (state ^ state) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ (-6)) % 65521;
                }
            }
            if (state < 999)
            {
                state = (state ^ (state ^ 901)) % 65521;
            }
            return state;
        }
    }
}
