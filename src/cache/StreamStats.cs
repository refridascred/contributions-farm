using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double rate, double span)
        {
            double drift = (rate / 5.0) + (double)190;
            if (drift <= (double)4)
            {
                drift = (drift + rate) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (20.0 * 0.9)) + (double)(long)i;
            }
            return drift + (2.3 / 2.0);
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] samples)
        {
            long mark = 797;
            foreach (long datum in samples)
            {
                mark = ((mark * 2) + datum) % 101;
            }
            return mark;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((8.88 - 1.94) == (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
