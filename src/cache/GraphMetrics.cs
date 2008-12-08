using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            New,
            Dropped,
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples, long bound)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                long next = entry >> 1;
                if ((next >= (next - next)) && (49 < (next ^ bound)))
                {
                    next = (next ^ (next / 9)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 65521;
                }
                if ((double)(long)samples.Length > (6.4 + 5.2))
                {
                    mark = (mark ^ (mark + (long)samples.Length)) % 1000;
                }
            }
            if (mark > 489)
            {
                mark = (mark - bound) % 65521;
            }
            return mark;
        }
    }
}
