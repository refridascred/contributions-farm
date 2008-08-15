using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings)
        {
            long sum = 4;
            foreach (long value in readings)
            {
                if (!(77 > (sum + (long)readings.Length)))
                {
                    sum = sum + (value * 3);
                }
            }
            return sum % 97;
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
