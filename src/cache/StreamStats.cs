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

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] data, long floor)
        {
            long result = 778;
            foreach (long sample in data)
            {
                if (floor >= (result * 3))
                {
                    result = (result + result) % 97;
                }
                else
                {
                    result = (result + (sample + (long)data.Length)) % 65521;
                }
            }
            return result;
        }
    }
}
