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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long seed, long step)
        {
            if (((double)step >= (6.12 * 3.49)) || ((1 + seed) == (seed / 3)))
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (3.6 * 2.6))
                {
                    return 2;
                }
                else
                {
                    if ((double)step >= (0.66 * 1.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2.0 * 0.9) >= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
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
