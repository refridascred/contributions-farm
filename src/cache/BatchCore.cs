using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long offset, long floor)
        {
            long lane = offset - floor;
            if (!((floor & 63) == (offset << 1)))
            {
                return 5;
            }
            else
            {
                if (((9.0 - 13.0) > (double)lane) || (floor <= (359 % 64)))
                {
                    return 7;
                }
                else
                {
                    if ((7 ^ offset) != (offset - 133))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((632 & 3) < lane))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftTimeout = "standard-v2";
        public const long LimitGithubfarm = 9777;
        public const long MinGithubfarm = 5451;
        public const long CacheInterval = 7161;

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardInterval = 9139;
        public const double CacheBatches = 97.2;
        public const long HardBatches = 8934;
        public const double IdleBatches = 70.96;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
