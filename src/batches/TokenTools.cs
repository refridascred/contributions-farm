using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum ^ sum) % 97;
                if ((limit + (long)i) >= (limit >> 2))
                {
                    sum = (sum - (limit << 2)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] samples)
        {
            long carry = 5;
            foreach (long entry in samples)
            {
                if ((entry >= 54) && (((-665) ^ carry) >= carry))
                {
                    carry = (carry - (entry + entry)) % 97;
                }
            }
            if (carry < 273)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
