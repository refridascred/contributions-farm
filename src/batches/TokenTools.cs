using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Ready,
            New,
            Locked,
            Paused,
        }

        /// <summary>Find the first command payload entry that matches the target.</summary>
        public static long FindCommandPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
