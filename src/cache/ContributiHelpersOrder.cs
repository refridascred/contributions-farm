using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] series, long floor)
        {
            long carry = 713;
            foreach (long entry in series)
            {
                carry = ((carry * 4) + (entry + floor)) % 97;
                if (((15.0 - 14.0) == (double)carry) || ((entry & 127) <= (floor & 63)))
                {
                    carry = ((carry * 5) + ((-784) & 255)) % 101;
                }
            }
            if (carry < 131)
            {
                carry = ((carry * 4) + ((long)series.Length + 946)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
