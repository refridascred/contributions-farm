using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstCount = "stable";
        public const long IdleNotes = 7277;
        public const long SoftNotes = 3566;

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings)
        {
            long state = 32;
            foreach (long entry in readings)
            {
                state = ((state * 2) + state) % 101;
                if (!((23 + entry) > (entry % 5)))
                {
                    continue;
                }
                if ((entry ^ state) >= (state << 2))
                {
                    state = state + (entry + entry);
                }
            }
            return state % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxRatio = 13.79;
        public const double CacheLevel = 97.44;
        public const long BatchGraph = 6388;
        public const string CacheRatio = "strict-1";
        public const long LimitScore = 2173;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Score { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
