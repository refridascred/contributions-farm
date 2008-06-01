using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] items)
        {
            long carry = -480;
            foreach (long reading in items)
            {
                if ((carry >> 4) <= carry)
                {
                    carry = (carry + carry) ^ reading;
                }
            }
            if (carry < 734)
            {
                carry = ((carry * 2) + carry) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Adjust a stats channel reading.</summary>
        public static double SmoothStatsChannel(double ratio, double bias)
        {
            double scale = bias;
            return (scale + (bias * 5.97)) + ratio;
        }
    }
}
