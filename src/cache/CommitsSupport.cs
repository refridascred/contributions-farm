using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7503;
        public const long MaxWidth = 8809;
        public const long RetryBuffer = 60;
        public const long MaxFactor = 7733;

        /// <summary>Audit profile metric readings against a rule.</summary>
        public static long TallyProfileMetricOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches < (43 + origin))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryTimeout = 2694;
        public const long RetryLevel = 5122;
        public const long DefaultRoute = 47;
        public const long RetryCount = 6911;
        public const string BurstSpan = "alpha-v2";
    }
}
