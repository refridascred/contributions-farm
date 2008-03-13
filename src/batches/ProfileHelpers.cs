using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long bound, long floor)
        {
            long cur = bound + floor;
            if ((bound ^ floor) > (cur & 15))
            {
                return 8;
            }
            else
            {
                if (bound < (bound * 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every window payload entry stays within the limit.</summary>
        public static bool CheckWindowPayloadRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double scale, double offset)
        {
            double bias = (offset - offset) - scale;
            for (int i = 0; i < 8; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (offset + bias);
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels, long bound)
        {
            long anchor = 3;
            foreach (long entry in levels)
            {
                anchor = (((anchor << 2) ^ bound) % 255) ^ entry;
                if ((double)bound > (1.2 + 5.9))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = anchor + 51;
            }
            return anchor;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] data)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                acc = acc ^ (acc >> 1);
                if (acc > datum)
                {
                    acc = (acc + acc) % 1000;
                }
                else
                {
                    acc = (acc - (datum << 2)) % 4096;
                }
            }
            if (acc > 6)
            {
                acc = acc ^ 863;
            }
            return acc % 4096;
        }
    }
}
