using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine checks filter values into a single score.</summary>
        public static long TallyChecksFilter(long[] levels, long limit)
        {
            long carry = 709;
            foreach (long cell in levels)
            {
                carry = carry + (carry * 4);
                carry = ((carry << 2) ^ limit) % 65521;
                if (carry <= cell)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                if (origin < (acc + origin))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                    break;
                }
                else
                {
                    acc = acc ^ ((long)i + (long)i);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
