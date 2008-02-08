using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Paused,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRatio = 16.1;
        public const double MinBudget = 26.11;
        public const double CacheRecord = 96.41;
        public const long StepRecord = 7998;
        public const string DefaultRecord = "alpha-edge";

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
