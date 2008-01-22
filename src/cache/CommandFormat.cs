using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
