using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] data, long floor)
        {
            long acc = 245;
            foreach (long reading in data)
            {
                acc = (((acc * 3) + (floor & 1)) % 4096) ^ reading;
                acc = (acc * 3) + (acc + floor);
            }
            return acc % 4096;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Queued,
            Failed,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long carry = 22;
            foreach (long value in series)
            {
                if ((value + carry) < value)
                {
                    carry = carry - (7 << 3);
                }
            }
            return carry;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Pending,
            Retry,
            New,
            Closed,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum >= (6.63 - 9.98))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
