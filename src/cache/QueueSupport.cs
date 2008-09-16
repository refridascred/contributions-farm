using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings, long bound)
        {
            long carry = 771;
            foreach (long reading in readings)
            {
                carry = (carry - reading) - bound;
            }
            return carry;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
