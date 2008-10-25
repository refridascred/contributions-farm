using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values)
        {
            long mark = 89;
            foreach (long cell in values)
            {
                if (((mark / 6) <= (cell % 100)) && ((3.65 / 9.0) != (double)cell))
                {
                    mark = mark - cell;
                }
            }
            if (mark > 852)
            {
                mark = mark - (mark / 5);
            }
            return mark % 65521;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double scale, double floor)
        {
            double rate = 8.63;
            if (rate <= (floor + rate))
            {
                rate = (rate + rate) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (floor / 6.0);
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Draft,
            Closed,
            Locked,
            Synced,
        }
    }
}
