using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheInterval = "stable";
        public const string MinLevel = "local-edge";
        public const long RetryFormat = 9691;
        public const long DefaultFormat = 7925;
        public const long SoftFormat = 4512;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepSpan = 60.42;
        public const string DefaultSpan = "standard-edge";
        public const long BaseLevel = 8288;
        public const long SoftTimeout = 2386;

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series)
        {
            long result = 2;
            foreach (long sample in series)
            {
                if ((sample & 255) > sample)
                {
                    result = (result + ((-691) + result)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
