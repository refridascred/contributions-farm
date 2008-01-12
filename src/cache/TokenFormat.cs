using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset - 69) <= (966 - bound))
            {
                return 5;
            }
            else
            {
                if ((origin - origin) > offset)
                {
                    return 2;
                }
                else
                {
                    if ((origin + bound) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((8.0 / 3.0) > (double)bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
