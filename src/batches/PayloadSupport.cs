using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading - 21) != (56 & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long target, long limit)
        {
            if ((target % 100) < (target % 97))
            {
                return 6;
            }
            else
            {
                if (limit <= (target % 100))
                {
                    return 2;
                }
                else
                {
                    if ((0.8 - 9.06) >= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit << 2) > limit) && ((limit << 3) < (limit >> 1)))
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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
