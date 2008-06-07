using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 211;
        public const double RetryCount = 84.78;
        public const double HardTimeout = 30.58;
        public const string HardRatio = "strict";
        public const string RetryInterval = "cached-v2";

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
