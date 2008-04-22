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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((98 % 3) < ((long)values.Length * 3))
                {
                    seen = ((seen + 3) + datum) - offset;
                }
            }
            return seen;
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
