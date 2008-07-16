using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (9.0 >= (double)seen)
                {
                    seen = ((seen + 2) ^ datum) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value - value) >= (value << 1))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }
    }
}
