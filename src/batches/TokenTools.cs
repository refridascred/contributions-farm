using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit order format readings against a rule.</summary>
        public static long MeasureOrderFormatOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry - tally) <= (tally / 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
