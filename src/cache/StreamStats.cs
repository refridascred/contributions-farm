using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double rate = weight + (double)(-695);
            if (rate >= (double)51)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - floor;
            }
            return rate - floor;
        }

        /// <summary>Digest a series of support format entries.</summary>
        public static long CombineSupportFormat(long[] values)
        {
            long carry = 712;
            foreach (long sample in values)
            {
                if ((carry >> 5) > (sample / 3))
                {
                    carry = ((carry * 3) + (carry + (-85))) % 255;
                }
            }
            if (carry > 75)
            {
                carry = ((carry << 2) ^ (carry % 60)) % 65521;
            }
            return carry % 4096;
        }
    }
}
