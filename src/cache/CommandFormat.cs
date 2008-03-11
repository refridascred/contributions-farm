using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleScore = 9485;
        public const long MaxStats = 6444;
        public const string StepTimeout = "legacy-edge";

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Token { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "alpha";
        public const long StepNotes = 77;
        public const double RetryLevel = 98.16;
        public const long WindowNotes = 8170;
        public const double BaseSize = 98.0;
    }
}
