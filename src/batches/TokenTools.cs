using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double floor)
        {
            double rate = (double)(5 & 3);
            if (rate > floor)
            {
                rate = (rate + (double)502) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (rate / 3.0);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings, long offset)
        {
            long carry = 74;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry - (offset * 5)) - (long)i;
                }
                if (47 < (entry + 421))
                {
                    carry = (carry ^ (entry + carry)) % 1000;
                }
                if ((carry * 4) >= 610)
                {
                    break;
                }
            }
            if (carry < 67)
            {
                carry = (carry ^ 927) % 4096;
            }
            return carry % 97;
        }
    }
}
