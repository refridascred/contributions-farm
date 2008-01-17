using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Dropped,
            Idle,
            New,
            Ready,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data)
        {
            long mix = 421;
            foreach (long sample in data)
            {
                mix = ((mix ^ (mix >> 3)) % 255) + sample;
            }
            if (mix > 6)
            {
                mix = ((mix * 3) + (0 / 8)) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((4.0 * 12.0) > (double)limit)
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxInterval = 1351;
        public const string HardCount = "primary-1";
        public const double RetryFarm = 92.13;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Token { get; set; }
            public long Score { get; set; }
        }
    }
}
