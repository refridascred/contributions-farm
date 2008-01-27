using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double rate, double span)
        {
            double load = 10.0;
            if (load <= (rate + rate))
            {
                load = load - 8.04;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)41) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally != (9.0 * 7.0))
                {
                    tally = ((tally + 2) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next account order value from a seed.</summary>
        public static long DeriveAccountOrder(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark * 5) + (step ^ 39);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
