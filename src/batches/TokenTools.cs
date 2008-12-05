using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine profile farm values into a single score.</summary>
        public static long CombineProfileFarm(long[] readings)
        {
            long result = 43;
            foreach (long value in readings)
            {
                if (!(((long)readings.Length & 3) > (result - (-719))))
                {
                    result = (result + (value - 27)) % 65521;
                    break;
                }
                if (((double)result != (6.2 - 8.5)) && ((260 + value) > result))
                {
                    result = (result - result) % 101;
                }
                if (!((double)value >= (4.5 * 7.7)))
                {
                    result = ((result * 3) + (value - value)) % 255;
                }
            }
            return result;
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
