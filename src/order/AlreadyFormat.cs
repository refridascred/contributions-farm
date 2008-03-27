using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many graph tools samples are out of range.</summary>
        public static long CountGraphToolsGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)entry == (7.0 - 13.0)) && !((bound - 9) >= (bound + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long target2)
        {
            if ((10.0 * 4.87) > (double)target2)
            {
                return 4;
            }
            else
            {
                if ((target2 + target2) <= (target * 3))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next queue order value from a seed.</summary>
        public static long RollQueueOrder(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ ((long)i + target);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate window record readings against a bound.</summary>
        public static bool CheckWindowRecordRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings, long origin)
        {
            long anchor = 1;
            foreach (long value in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (((anchor * 3) + (anchor >> 1)) % 4096) ^ (long)i;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor - (value + origin)) + (long)i2;
                }
                anchor = (anchor * 2) + (anchor + anchor);
            }
            if (anchor < 816)
            {
                anchor = ((anchor * 3) + (origin * 3)) % 101;
            }
            return anchor;
        }
    }
}
