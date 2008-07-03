using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate route filter readings against a bound.</summary>
        public static bool VerifyRouteFilterBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 1246;
        public const double BaseLevel = 1.45;
        public const long LimitInterval = 3362;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
        }
    }
}
