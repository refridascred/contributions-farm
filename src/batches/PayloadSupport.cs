using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen - seed) != (seed - seen))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + 55) < tally)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                if ((1.7 + 0.28) > (double)state)
                {
                    state = (state + (step - state)) % 97;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
