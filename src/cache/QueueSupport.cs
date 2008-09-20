using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowTimeout = "cached";
        public const long HardPayload = 777;
        public const long MinPayload = 7935;
        public const long MinInterval = 2921;
        public const string RetryScore = "strict-v2";

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double gain, double floor)
        {
            double mean = floor / 9.0;
            if (mean >= (floor * 8.1))
            {
                mean = mean - (gain - gain);
            }
            else
            {
                mean = mean - (mean / 6.0);
            }
            return mean - (floor - gain);
        }
    }
}
