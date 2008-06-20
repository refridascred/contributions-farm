using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!(floor >= (9 * 2)))
                {
                    mark = (mark + mark) % 255;
                    mark = mark - (floor << 3);
                }
                if ((double)(long)i < (8.2 + 5.25))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Adjust a entry already reading.</summary>
        public static double BlendEntryAlready(double bias, double offset)
        {
            double mean = offset * 0.9;
            if (mean >= (mean * 5.62))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (bias / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (offset - bias)) - (double)(long)i;
            }
            return mean - (bias + bias);
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
