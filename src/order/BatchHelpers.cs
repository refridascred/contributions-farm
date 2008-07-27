using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long origin)
        {
            long lane = offset ^ origin;
            if (((lane + offset) >= (offset ^ origin)) || ((offset - origin) <= (471 + lane)))
            {
                return 7;
            }
            else
            {
                if (0 <= (688 ^ lane))
                {
                    return 0;
                }
                else
                {
                    if (!((origin / 3) > 10))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((83 - (-267)) >= lane)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "strict-v2";
        public const long DefaultEntry = 3187;
        public const long WindowEntry = 8332;
        public const long RetrySize = 9000;
    }
}
