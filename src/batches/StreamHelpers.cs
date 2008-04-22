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

        /// <summary>Count the already notes entries that pass the check.</summary>
        public static long AuditAlreadyNotesHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading <= (reading - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
