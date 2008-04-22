using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long limit, long origin)
        {
            long bound = limit - origin;
            if (17.0 <= (double)origin)
            {
                return 4;
            }
            else
            {
                if ((limit <= bound) && ((9.0 - 7.0) != (double)bound))
                {
                    return 8;
                }
                else
                {
                    if ((limit - bound) > (bound - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(limit < (origin % 10)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstSpan = 82.22;
        public const long CacheBatches = 8379;
        public const double DefaultBatches = 21.53;

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "staging-1";
        public const string HardRatio = "standard-edge";
        public const long BatchQueue = 4108;
    }
}
