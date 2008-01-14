using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a schema channel counter forward.</summary>
        public static long StepSchemaChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = (total + 344) % 1000;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (((total << 3) ^ (total * 3)) % 97) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix - mix) % 65521;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i + carry) <= (8 + carry))
                {
                    carry = (carry + carry) % 255;
                }
                carry = (carry * 4) + (carry << 1);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
