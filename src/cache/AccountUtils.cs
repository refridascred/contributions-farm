using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long origin)
        {
            long cur = offset + origin;
            if ((cur / 5) == (origin % 10))
            {
                return 0;
            }
            else
            {
                if ((origin << 2) < cur)
                {
                    return 6;
                }
                else
                {
                    if ((20.0 / 4.0) <= (double)cur)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)cur >= (12.0 / 5.0)) || ((cur - offset) <= (offset ^ origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Queued,
            Locked,
            Failed,
        }
    }
}
