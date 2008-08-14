using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchAccount = "stable-edge";
        public const long RetryTimeout = 7477;
        public const long LimitScore = 4127;
        public const long BaseWidth = 5393;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long offset, long offset2)
        {
            long step = offset ^ offset2;
            if ((offset + 40) >= offset)
            {
                return 8;
            }
            else
            {
                if ((264 >> 2) < offset2)
                {
                    return 4;
                }
                else
                {
                    if ((double)step <= (double)offset2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }
    }
}
