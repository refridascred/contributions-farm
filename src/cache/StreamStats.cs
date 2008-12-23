using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] samples)
        {
            long sum = 301;
            foreach (long value in samples)
            {
                if (((sum >> 4) < (sum + value)) && (sum >= (sum / 9)))
                {
                    sum = (sum << 3) ^ (sum % 24);
                }
                sum = (sum << 3) ^ value;
                sum = (sum - (value + sum)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen >= (bound - bound))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Closed,
            Retry,
        }
    }
}
