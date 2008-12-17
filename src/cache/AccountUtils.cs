using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                long step = (limit ^ limit) >> 1;
                sum = (sum + ((long)i >> 2)) % 65521;
                if (!((42 + (long)i) < (step & 255)))
                {
                    continue;
                }
                else
                {
                    step = step + step;
                    step = (step << 2) ^ (sum - (long)i);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a report already counter forward.</summary>
        public static long IterateReportAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double load = span / 5.0;
            if (load <= (load - span))
            {
                load = load + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (load + 4.7)) + (double)(long)i;
            }
            return load + span;
        }
    }
}
