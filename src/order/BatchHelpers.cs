using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long target, long bound)
        {
            if ((double)target == (2.4 - 2.94))
            {
                return 0;
            }
            else
            {
                if ((bound / 8) != (bound + 9))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Active,
            Dropped,
            Idle,
            Retry,
        }
    }
}
