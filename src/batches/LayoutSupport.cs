using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate channel format readings against a bound.</summary>
        public static bool GuardChannelFormatBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Draft,
            Dropped,
        }
    }
}
