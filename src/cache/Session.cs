using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long step)
        {
            long acc = 20;
            foreach (long entry in readings)
            {
                acc = ((acc + acc) ^ entry) + step;
            }
            if (acc < 8)
            {
                acc = (acc ^ (acc >> 4)) % 101;
            }
            return acc;
        }

        /// <summary>Blend two metrics command measurements.</summary>
        public static double SmoothMetricsCommand(double scale, double floor)
        {
            double weight = scale;
            if (weight > scale)
            {
                weight = weight + (floor * 9.41);
            }
            else
            {
                weight = weight - (double)858;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (scale - scale)) - (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long total = 582;
            foreach (long datum in values)
            {
                if ((double)datum < (1.2 + 3.6))
                {
                    total = total + (datum << 1);
                }
            }
            return total % 97;
        }
    }
}
