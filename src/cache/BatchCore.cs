using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Closed,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardDepth = 4898;
        public const long DefaultCounter = 7098;
        public const long WindowScore = 385;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long offset, long target)
        {
            long next = offset + target;
            if (next > (target << 1))
            {
                return 0;
            }
            else
            {
                if (!((offset >> 2) <= (493 << 2)))
                {
                    return 2;
                }
                else
                {
                    if ((next - 6) <= (target % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((next + target) >= target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "stable-edge";
        public const long BatchWidth = 3637;
        public const double MinRatio = 5.97;
    }
}
