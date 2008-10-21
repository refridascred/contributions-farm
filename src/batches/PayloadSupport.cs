using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Draft,
            Paused,
            Done,
            Idle,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings)
        {
            long carry = 2;
            foreach (long value in readings)
            {
                carry = ((carry << 3) ^ 454) - value;
            }
            return carry % 1000;
        }

        /// <summary>Audit queue tools readings against a rule.</summary>
        public static long CountQueueToolsHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (floor >= (floor / 2))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }
    }
}
