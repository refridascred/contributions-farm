using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 5891;
        public const long StepSize = 6835;
        public const long LimitPayload = 1815;
        public const long SoftDepth = 617;

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 3551;
        public const double MinSpan = 52.67;
        public const long MaxSupport = 414;

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double span)
        {
            double drift = span - span;
            return drift - (gain - span);
        }
    }
}
