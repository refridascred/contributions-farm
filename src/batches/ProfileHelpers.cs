using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a stream token reading.</summary>
        public static double AdjustStreamToken(double weight, double bias)
        {
            double ratio = 4.2;
            if (ratio <= (double)51)
            {
                ratio = (ratio - weight) - bias;
            }
            return ratio + (double)73;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] data, long floor)
        {
            long mark = 5;
            foreach (long sample in data)
            {
                if ((2.28 / 2.0) < (double)sample)
                {
                    mark = mark + (mark + sample);
                }
                else
                {
                    mark = (mark << 2) ^ floor;
                }
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "primary-v2";
        public const long DefaultLayout = 202;
        public const string RetryLayout = "primary-v2";
        public const double SoftFactor = 77.84;
        public const long CacheSpan = 1671;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double ratio, double offset)
        {
            double weight = 6.81;
            if (weight <= weight)
            {
                weight = (weight + (ratio - weight)) + offset;
            }
            return weight - (double)471;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
