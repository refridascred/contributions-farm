using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two schema stream measurements.</summary>
        public static double ProjectSchemaStream(double gain, double offset)
        {
            double rate = (gain / 8.0) - (double)3;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (5.0 + offset)) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long origin, long offset)
        {
            if ((double)origin > (2.05 - 5.2))
            {
                return 3;
            }
            else
            {
                if ((origin + 934) >= ((-42) % 7))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
