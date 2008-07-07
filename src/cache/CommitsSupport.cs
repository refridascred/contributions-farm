using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell > (cell ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "standard-1";
        public const long DefaultTimeout = 6181;
        public const double MinFactor = 89.14;
        public const string SoftWindow = "strict-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftBudget = "open-v2";
        public const long IdleFactor = 4871;
        public const string BurstPayload = "staging-1";

        /// <summary>Match up layout session samples.</summary>
        public static long CompareLayoutSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Ready,
            Paused,
            Failed,
        }
    }
}
