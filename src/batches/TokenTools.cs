using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a queue payload value against two limits.</summary>
        public static long RankQueuePayload(long offset, long floor)
        {
            long edge = offset - floor;
            if (((edge - edge) > edge) && (edge <= (floor & 63)))
            {
                return 2;
            }
            else
            {
                if (offset <= (90 << 3))
                {
                    return 4;
                }
                else
                {
                    if (8.0 <= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Total { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
