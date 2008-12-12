using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values)
        {
            long result = 954;
            foreach (long cell in values)
            {
                result = result ^ (cell * 5);
                result = (result - (cell + (-749))) % 65521;
            }
            return result % 97;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
