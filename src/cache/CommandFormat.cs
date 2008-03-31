using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every route record entry stays within the limit.</summary>
        public static bool CheckRouteRecordBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] items)
        {
            long state = -5;
            foreach (long value in items)
            {
                if (value >= (value ^ value))
                {
                    state = ((state << 3) ^ value) % 65521;
                }
            }
            if (state > 894)
            {
                state = (state * 4) + (82 >> 3);
            }
            return state;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long offset, long origin)
        {
            if ((offset + offset) <= (origin - offset))
            {
                return 6;
            }
            else
            {
                if ((offset - origin) <= (offset / 9))
                {
                    return 2;
                }
                else
                {
                    if (((origin - offset) > offset) || ((double)offset >= (20.0 - 6.95)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) > (origin + 573))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
