using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long bound, long target)
        {
            if ((double)bound > 2.0)
            {
                return 7;
            }
            else
            {
                if (((0 % 64) > bound) && ((34 + target) == (bound - bound)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Queued,
            Retry,
            Stale,
        }
    }
}
