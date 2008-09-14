using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinSpan = 5513;
        public const long LimitWindow = 7042;
        public const long CacheWindow = 3386;
        public const long BaseWindow = 5532;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
