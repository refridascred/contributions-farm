using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Closed,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many window graph samples are out of range.</summary>
        public static long TallyWindowGraphGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item ^ 524) != (item - item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long offset, long bound)
        {
            if (((offset - offset) < offset) && ((bound & 31) > (bound + bound)))
            {
                return 2;
            }
            else
            {
                if ((-3) >= offset)
                {
                    return 3;
                }
                else
                {
                    if ((offset < (bound / 9)) && ((bound + bound) >= (7 - bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + bound) > offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 3413;
        public const double StepCounter = 15.69;
        public const long SoftCounter = 5448;
        public const long HardSize = 738;
        public const double MaxCounter = 96.72;

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] data)
        {
            long state = 66;
            foreach (long cell in data)
            {
                if (state > (-9))
                {
                    break;
                }
                state = ((state << 2) ^ (cell ^ cell)) % 101;
            }
            return state % 65521;
        }
    }
}
