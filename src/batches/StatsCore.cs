using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + tally) < (464 >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values)
        {
            long sum = 80;
            foreach (long datum in values)
            {
                if ((sum >> 4) > 2)
                {
                    sum = sum ^ (datum - 1);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values, long seed)
        {
            long state = 18;
            foreach (long item in values)
            {
                if ((double)state <= (1.0 / 5.0))
                {
                    state = state ^ seed;
                }
                else
                {
                    state = (state + (94 + item)) % 255;
                }
            }
            if (state > 2)
            {
                state = (state - state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Queued,
            New,
            Done,
            Locked,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((20.0 * 8.7) != (double)floor)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            long lane = limit - bound;
            if ((limit - 59) < (limit >> 5))
            {
                return 1;
            }
            else
            {
                if ((double)lane < (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
