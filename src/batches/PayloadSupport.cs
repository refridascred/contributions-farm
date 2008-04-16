using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSpan = "latest-v2";
        public const long RetryCount = 182;
        public const long BurstScore = 6445;
        public const long IdleSchema = 9470;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Draft,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long target, long origin)
        {
            if (((origin / 9) >= 884) || ((origin >> 3) >= (target & 31)))
            {
                return 0;
            }
            else
            {
                if ((target / 6) <= origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin << 2) > (678 + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target / 5) > (target >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
