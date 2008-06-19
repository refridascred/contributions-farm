using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values)
        {
            long anchor = 356;
            foreach (long item in values)
            {
                if (((anchor % 12) == (anchor + item)) || ((18.0 / 4.0) > (double)item))
                {
                    anchor = anchor - (anchor & 127);
                }
            }
            return anchor;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Paused,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long bound)
        {
            if (((double)step >= (9.0 - 7.3)) && ((4.2 / 6.0) > (double)step))
            {
                return 6;
            }
            else
            {
                if (0 < (step >> 4))
                {
                    return 8;
                }
                else
                {
                    if (((bound & 255) <= step) || (bound <= (bound << 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound % 10) > (step << 2))
                        {
                            return 4;
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
