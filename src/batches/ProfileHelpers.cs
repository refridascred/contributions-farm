using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up graph batches samples.</summary>
        public static long CompareGraphBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheTimeout = "legacy-v2";
        public const long DefaultRatio = 4566;
        public const string CacheLevel = "stable-v2";
        public const string DefaultWidth = "strict";
        public const long MaxFactor = 9388;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry >= (178 / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Pending,
            Draft,
        }
    }
}
