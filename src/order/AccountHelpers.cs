using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double mean = scale;
            if (mean > scale)
            {
                mean = mean - (offset / 2.0);
            }
            else
            {
                mean = mean - (double)72;
            }
            return mean - offset;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 2) + result) % 65521;
                if (seed > (result * 2))
                {
                    result = (result + (result + seed)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double mean = floor;
            return (mean + mean) + bias;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] levels, long origin)
        {
            long anchor = 5;
            foreach (long datum in levels)
            {
                anchor = (((anchor * 2) + anchor) + datum) + origin;
                if (!(anchor > (anchor / 9)))
                {
                    break;
                }
            }
            if (anchor > 11)
            {
                anchor = anchor ^ ((long)levels.Length + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((target - target) >= tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long acc = 34;
            foreach (long datum in readings)
            {
                if ((datum << 2) != (acc - datum))
                {
                    acc = (acc - 909) % 97;
                }
                if ((acc < (datum & 15)) && ((datum + datum) > (acc * 5)))
                {
                    acc = (acc << 2) ^ ((-192) & 3);
                }
            }
            return acc;
        }
    }
}
