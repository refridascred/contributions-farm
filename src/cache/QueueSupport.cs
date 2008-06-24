using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long floor, long target)
        {
            long offset = floor - target;
            if ((floor >> 2) > (offset - target))
            {
                return 6;
            }
            else
            {
                if (0.5 < (double)target)
                {
                    return 5;
                }
                else
                {
                    if (((double)offset < (double)(-9)) && (floor <= offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
