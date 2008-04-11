using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long bound, long offset)
        {
            if ((offset % 16) < bound)
            {
                return 8;
            }
            else
            {
                if ((bound << 2) == (27 & 3))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (offset + 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((bound >> 4) >= (offset % 100)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Closed,
            Idle,
            Retry,
        }
    }
}
