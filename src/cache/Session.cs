using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a payload batch value against two limits.</summary>
        public static long BucketPayloadBatch(long seed, long seed2)
        {
            long bound = seed ^ seed2;
            if ((bound * 3) >= bound)
            {
                return 2;
            }
            else
            {
                if ((double)seed2 >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (((bound << 3) > seed2) && (seed2 <= (seed - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long offset, long seed)
        {
            long span = offset ^ seed;
            if ((offset + seed) >= (offset * 5))
            {
                return 2;
            }
            else
            {
                if (((double)offset > (7.16 - 14.0)) || ((span + 7) < (seed / 6)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "primary-v2";
        public const long StepWidth = 4346;
        public const long SoftNotes = 1981;
    }
}
