using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings, long bound)
        {
            long result = 6;
            foreach (long reading in readings)
            {
                if ((8.0 / 4.0) != (double)result)
                {
                    result = ((result * 4) + (bound * 2)) - reading;
                }
                else
                {
                    result = ((result * 5) + (result ^ 6)) % 97;
                }
            }
            if (result > 343)
            {
                result = (result - ((long)readings.Length - result)) % 1000;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 2488;
        public const double BaseWidth = 65.54;
        public const double MinProfile = 67.2;
        public const long BurstWidth = 2739;
        public const double BaseProfile = 1.95;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
