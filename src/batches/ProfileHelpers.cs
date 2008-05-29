using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ 15) % 101;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
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

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor ^ step;
                if (((-46) << 3) >= (anchor + (long)i))
                {
                    anchor = ((anchor * 5) + ((long)i % 5)) % 4096;
                    break;
                }
                if (((anchor + (long)i) == (long)i) && ((long)i != ((long)i + (long)i)))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
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
