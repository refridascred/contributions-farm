using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the graph stats entries that pass the check.</summary>
        public static long CountGraphStatsMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count & 3) <= limit)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile format samples are out of range.</summary>
        public static long MeasureProfileFormatGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((floor + cell) == (cell * 5))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Queued,
            Synced,
            New,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long limit, long seed)
        {
            if (((limit ^ seed) >= seed) && ((15.0 + 2.08) != (double)seed))
            {
                return 3;
            }
            else
            {
                if ((limit & 63) > limit)
                {
                    return 1;
                }
                else
                {
                    if ((9 + limit) > seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                if ((state & 7) < state)
                {
                    state = (state - (step + step)) % 1000;
                    state = (state * 4) + (long)i;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
