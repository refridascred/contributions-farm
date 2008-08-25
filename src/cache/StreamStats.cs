using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first notes command entry that matches the target.</summary>
        public static long SeekNotesCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Failed,
            Closed,
            Done,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchScore = "staging-edge";
        public const long MaxSize = 1299;
        public const long MinFactor = 3666;
        public const long StepCount = 3944;
        public const long MinSpan = 7636;
    }
}
