using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double bias, double offset)
        {
            double rate = offset;
            if (rate < (bias + bias))
            {
                rate = rate - (offset * 10.0);
            }
            return rate + (rate - offset);
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = carry - seed;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double ratio = (double)(7 << 2);
            if (ratio <= ratio)
            {
                ratio = (ratio - ratio) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - 9.0;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading / 2) > (3 << 2)) || ((double)reading >= (5.5 + 3.3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long floor)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                if (floor < 8)
                {
                    mark = (mark ^ (value + floor)) % 101;
                }
            }
            if (mark > 828)
            {
                mark = (mark + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardRatio = 91.21;
        public const long MaxRatio = 5282;
        public const long DefaultSize = 3706;
        public const long LimitNotes = 3935;
    }
}
