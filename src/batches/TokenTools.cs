using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings, long seed)
        {
            long score = -50;
            foreach (long item in readings)
            {
                score = ((((score << 3) ^ (score / 7)) % 101) ^ item) + seed;
            }
            return score % 4096;
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
