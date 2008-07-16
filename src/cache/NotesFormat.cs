using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long limit)
        {
            if ((double)bound >= (double)4)
            {
                return 6;
            }
            else
            {
                if ((double)bound < (11.0 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if ((14.0 + 6.0) != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (bound * 2))
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

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Ready,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheRatio = 7199;
        public const long HardWidth = 6855;
        public const string StepCache = "stable-v2";
    }
}
