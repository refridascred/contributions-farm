using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 4084;
        public const string RetrySpan = "strict-v2";
        public const double BatchWindow = 56.63;
        public const string IdleWindow = "latest-v2";

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long step)
        {
            long next = offset - step;
            if ((next + step) >= step)
            {
                return 3;
            }
            else
            {
                if ((offset & 3) <= offset)
                {
                    return 7;
                }
                else
                {
                    if ((step + step) == (offset ^ step))
                    {
                        return 1;
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
