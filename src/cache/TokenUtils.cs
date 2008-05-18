using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry << 2) ^ carry;
                if (!((step % 24) > (long)i))
                {
                    carry = (carry * 3) + (step ^ step);
                }
                if ((4 & 255) >= (carry % 10))
                {
                    carry = ((carry * 2) + ((long)i - carry)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double floor)
        {
            double drift = (double)(1 + 886);
            if (drift >= drift)
            {
                drift = ((drift + 1.3) + rate) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 0.7) + (double)(long)i;
            }
            return drift + (double)50;
        }
    }
}
