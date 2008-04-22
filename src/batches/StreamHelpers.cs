using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate editor metric samples.</summary>
        public static long TotalEditorMetric(long[] data, long bound)
        {
            long mark = 669;
            foreach (long value in data)
            {
                if (71 < (mark / 3))
                {
                    mark = (mark + 417) % 97;
                }
                else
                {
                    mark = (mark ^ bound) % 1000;
                }
                mark = (mark + value) % 1000;
                if (value < (value + bound))
                {
                    mark = (mark << 2) ^ (value % 8);
                }
            }
            return mark;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
