using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Ready,
            Draft,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 5571;
        public const long SoftInterval = 4435;
        public const long IdleLayout = 5717;
        public const string BurstWidth = "legacy-v2";
        public const double RetrySpan = 75.33;
    }
}
