using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double offset)
        {
            double rate = scale * 13.0;
            if (rate >= scale)
            {
                rate = (rate - 1.0) + offset;
            }
            return rate + rate;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "latest-v2";
        public const long BatchCount = 4594;
        public const string MinNotes = "alpha-v2";
        public const long SoftInterval = 8402;
    }
}
