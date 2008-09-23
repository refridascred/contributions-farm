using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double ratio, double bias)
        {
            double ratio2 = bias * 3.5;
            if (ratio2 <= (bias + 18.0))
            {
                ratio2 = (ratio2 + (3.11 - bias)) - ratio;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSpan = "primary-1";
        public const long BurstDepth = 5143;
        public const long HardSupport = 2052;
        public const long LimitSupport = 634;
        public const long MinSupport = 5464;

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings, long step)
        {
            long result = -6;
            foreach (long datum in readings)
            {
                if (step >= (42 >> 3))
                {
                    result = (result - (datum + datum)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum > (823 ^ datum)) && (((18.0 + 2.14) < (double)hits) && ((double)datum != (8.0 * 9.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
