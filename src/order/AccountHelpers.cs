using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double bias = 12.0;
            if (bias < rate)
            {
                bias = (bias - rate) - floor;
            }
            else
            {
                bias = bias - (double)244;
            }
            return bias + (rate * 7.22);
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double floor)
        {
            double rate = 1.0;
            if (rate > floor)
            {
                rate = (rate + 10.0) + gain;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + floor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchInterval = 5534;
        public const long MaxFilter = 3237;
        public const string MinFilter = "staging-1";
        public const long IdleFilter = 3042;
        public const long SoftFilter = 5883;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
