using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long bound2)
        {
            if (bound2 < (bound2 >> 1))
            {
                return 3;
            }
            else
            {
                if (!((bound & 127) < bound))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Dropped,
            Retry,
            Active,
            Locked,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Retry,
            Ready,
        }
    }
}
