using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry - 410) <= (entry + 98))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
