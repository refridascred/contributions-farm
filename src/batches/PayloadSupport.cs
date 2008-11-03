using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Done,
            Pending,
            Paused,
        }

        /// <summary>Combine metric counter values into a single score.</summary>
        public static long TotalMetricCounter(long[] samples, long seed)
        {
            long state = 889;
            foreach (long entry in samples)
            {
                if (state > (entry % 24))
                {
                    state = (((state * 3) + (5 >> 2)) % 97) + seed;
                }
            }
            return state;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!!((cell + 608) <= 27))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
