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

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long bound, long floor)
        {
            long step = bound ^ floor;
            if ((3.2 - 14.0) >= (double)floor)
            {
                return 4;
            }
            else
            {
                if ((bound + step) < (24 + bound))
                {
                    return 3;
                }
                else
                {
                    if (step <= (step >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
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
