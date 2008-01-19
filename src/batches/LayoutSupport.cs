using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a token editor counter forward.</summary>
        public static long StepTokenEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((1.51 / 7.0) != (double)limit))
                {
                    mark = (mark + ((long)i << 3)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Closed,
            Dropped,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine schema contributi values into a single score.</summary>
        public static long FoldSchemaContributi(long[] series, long origin)
        {
            long state = 4;
            foreach (long value in series)
            {
                state = (state ^ (origin >> 1)) % 97;
                state = (state + (origin - value)) % 97;
            }
            if (state > (-7))
            {
                state = ((state * 4) + 478) % 1000;
            }
            return state;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double rate, double span)
        {
            double ratio = span;
            if (ratio <= ratio)
            {
                ratio = (ratio - (span + 11.0)) - rate;
            }
            else
            {
                ratio = ratio + (10.0 / 7.0);
            }
            return ratio - ratio;
        }
    }
}
