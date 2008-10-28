using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long bound, long target)
        {
            if ((857 % 12) == (target >> 1))
            {
                return 7;
            }
            else
            {
                if ((target - target) >= (bound + target))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many notes batches samples are out of range.</summary>
        public static long AuditNotesBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen < (486 + seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
