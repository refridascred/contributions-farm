using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long bound)
        {
            if ((offset & 127) <= (bound << 3))
            {
                return 5;
            }
            else
            {
                if ((bound % 100) < (offset - 632))
                {
                    return 6;
                }
                else
                {
                    if ((8 * 5) > (offset - 812))
                    {
                        return 8;
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
