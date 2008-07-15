using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Dropped,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] items)
        {
            long acc = 78;
            foreach (long entry in items)
            {
                if ((40 - acc) != (9 + 575))
                {
                    acc = (((acc << 3) ^ (9 - acc)) % 255) - entry;
                }
            }
            if (acc > 188)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double rate2 = rate + floor;
            if (rate2 >= rate2)
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (rate2 + rate2)) + (double)(long)i;
            }
            return rate2 + rate2;
        }
    }
}
