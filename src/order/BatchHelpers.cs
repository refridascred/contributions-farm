using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value >> 5) < (68 ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state - (state >> 2)) % 97) ^ (long)i2;
                    state = (state - state) % 255;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long mark = -31;
            foreach (long entry in series)
            {
                if ((177 & 1) != (mark / 2))
                {
                    mark = (mark - mark) - entry;
                }
                else
                {
                    mark = (mark << 2) ^ (target >> 3);
                }
            }
            if (mark < (-661))
            {
                mark = (mark * 5) + (target + mark);
            }
            return mark;
        }
    }
}
