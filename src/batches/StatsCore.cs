using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 5) + sum) % 255;
                sum = (sum ^ ((long)i - sum)) % 1000;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinCount = 8864;
        public const string StepSize = "legacy-v2";
        public const long BatchSize = 8039;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + value) != (value - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Flag { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
