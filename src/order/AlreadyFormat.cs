using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the checks payload series from a seed.</summary>
        public static long StepChecksPayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum ^ 6) % 1000) + (long)i2;
                    sum = (sum - (sum & 1)) % 101;
                }
                sum = (sum * 4) + (sum / 4);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Dropped,
            Queued,
            Done,
            Failed,
        }
    }
}
