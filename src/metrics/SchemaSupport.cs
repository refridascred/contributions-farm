using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((step - seen) >= (step - step)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Check that every format session entry stays within the limit.</summary>
        public static bool CheckFormatSessionBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
