using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen < (datum * 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = state ^ ((-5) * 3);
                if (!(((long)i - floor) < (floor / 6)))
                {
                    state = state ^ (state & 1);
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double scale, double offset)
        {
            double load = (offset / 8.0) + offset;
            if (load <= (load * 0.4))
            {
                load = load - scale;
            }
            else
            {
                load = load - (0.2 / 5.0);
            }
            return load + (offset * 2.3);
        }
    }
}
