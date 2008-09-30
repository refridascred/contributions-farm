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

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 1483;
        public const long BaseToken = 154;
        public const string RetryFactor = "stable";
    }
}
