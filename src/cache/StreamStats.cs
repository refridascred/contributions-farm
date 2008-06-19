using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                if (((924 - (long)i) >= (long)i) || ((acc << 1) >= step))
                {
                    acc = acc ^ (acc ^ (long)i);
                    continue;
                }
                acc = (acc * 5) + acc;
                acc = acc - (long)i;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double bias, double offset)
        {
            double weight = bias;
            if (weight < (double)882)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (0.6 * 0.14)) + (double)(long)i;
            }
            return weight - 3.5;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] items)
        {
            long result = -585;
            foreach (long datum in items)
            {
                if (!((datum + result) == (result >> 3)))
                {
                    result = (result - (datum + result)) % 1000;
                }
                result = (result - (result >> 4)) % 1000;
                if ((4.0 + 0.48) == (double)result)
                {
                    result = (result + datum) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (1 ^ datum)) % 97;
                }
            }
            if (result > 521)
            {
                result = result - (result >> 3);
            }
            return result % 4096;
        }
    }
}
