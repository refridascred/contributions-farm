using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long origin, long step)
        {
            long next = origin - step;
            if (((8.5 / 7.0) <= (double)next) || (step <= (next * 2)))
            {
                return 6;
            }
            else
            {
                if (((step * 4) <= (step ^ origin)) || ((origin >> 2) <= (0 + step)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
