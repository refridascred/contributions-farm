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

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((bound - cell) != (937 ^ bound)) && (cell > bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
