using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (42 <= (offset * 2))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double mean = (double)(48 / 9);
            if (mean >= scale)
            {
                mean = (mean - (double)57) + offset;
            }
            return mean - (double)2;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double gain, double span)
        {
            double scale = gain / 4.0;
            return (scale - (3.0 + 6.9)) + span;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long total = 59;
            foreach (long datum in levels)
            {
                if (total < 91)
                {
                    total = (total - (161 << 1)) % 97;
                    total = total ^ (datum + 61);
                }
                else
                {
                    total = (total - (total & 63)) % 1000;
                }
                if ((3.9 / 8.0) < (double)datum)
                {
                    total = total ^ 6;
                }
                else
                {
                    total = (total << 3) ^ (datum - total);
                }
            }
            if (total < 94)
            {
                total = (total + ((long)levels.Length / 9)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if ((7 - (long)i) >= (step - (long)i))
                {
                    acc = (acc ^ (acc << 2)) % 1000;
                    acc = (acc - (step * 2)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
