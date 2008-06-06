using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of order window entries.</summary>
        public static long FoldOrderWindow(long[] readings, long bound)
        {
            long anchor = 0;
            foreach (long item in readings)
            {
                if ((800 >> 1) >= (anchor + bound))
                {
                    anchor = (((anchor << 3) ^ (bound % 3)) % 255) + item;
                }
            }
            return anchor;
        }

        /// <summary>Roll a command metrics counter forward.</summary>
        public static long StepCommandMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values, long seed)
        {
            long anchor = 28;
            foreach (long cell in values)
            {
                if (anchor >= (cell + cell))
                {
                    anchor = ((anchor + (anchor << 3)) % 101) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
