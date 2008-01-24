using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many route channel samples are out of range.</summary>
        public static long MeasureRouteChannelMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 2) <= (1 % 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] samples)
        {
            long total = -3;
            foreach (long entry in samples)
            {
                if ((entry + 287) != (total + total))
                {
                    total = total - total;
                }
                else
                {
                    total = ((total * 2) + (total ^ total)) % 101;
                }
            }
            return total;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double floor)
        {
            double load = (double)(2 + 66);
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (floor * 5.6)) - (double)(long)i) - scale;
            }
            return load + floor;
        }
    }
}
