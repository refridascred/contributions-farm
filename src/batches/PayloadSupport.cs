using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Count { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            if ((685 - bound) > (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((bound >= (bound + origin)) || ((720 << 1) < origin))
                {
                    return 0;
                }
                else
                {
                    if ((origin * 5) >= (bound ^ 28))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((0.2 / 2.0) != (double)origin) || ((double)origin >= (double)5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
