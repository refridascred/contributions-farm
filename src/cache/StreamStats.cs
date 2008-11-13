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

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "local-edge";
        public const string BatchInterval = "open-v2";
        public const long WindowContext = 2672;

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
