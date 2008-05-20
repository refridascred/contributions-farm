using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of account batch entries.</summary>
        public static long ScoreAccountBatch(long[] series, long seed)
        {
            long state = 128;
            foreach (long entry in series)
            {
                if ((entry * 5) == (seed & 63))
                {
                    state = state + entry;
                    state = state ^ ((long)series.Length - seed);
                    continue;
                }
                state = (state ^ 1) % 97;
            }
            return state;
        }

        /// <summary>Measure how many metric command samples are out of range.</summary>
        public static long CountMetricCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading - (-861)) == (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
