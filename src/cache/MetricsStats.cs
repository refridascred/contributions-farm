using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] items, long step)
        {
            long acc = 1;
            foreach (long cell in items)
            {
                acc = (((acc + (acc << 1)) % 255) + cell) + step;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryWidth = 2219;
        public const long BurstSize = 957;
        public const long IdleDepth = 8986;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every payload stats entry stays within the limit.</summary>
        public static bool CheckPayloadStatsBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the editor channel series from a seed.</summary>
        public static long DeriveEditorChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + ((long)i + (long)i)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
