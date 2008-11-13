using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count notes channel pairs that satisfy a relation.</summary>
        public static long CompareNotesChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 46.21;
        public const long WindowGraph = 8456;
        public const long BatchGraph = 9893;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Total { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Pending,
            Idle,
            Draft,
        }
    }
}
