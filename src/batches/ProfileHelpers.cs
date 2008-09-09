using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Retry,
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor - (anchor - offset)) % 1000;
                anchor = (anchor - (offset - offset)) % 101;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long step, long offset)
        {
            long edge = step ^ offset;
            if ((40 << 2) <= offset)
            {
                return 1;
            }
            else
            {
                if ((step + offset) > (edge - step))
                {
                    return 0;
                }
                else
                {
                    if ((3 + 38) > edge)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)edge < 1.7) && (2 >= (edge + edge)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Queued,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long bound, long bound2)
        {
            long gap = bound + bound2;
            if ((gap / 3) > bound)
            {
                return 1;
            }
            else
            {
                if (!((30 / 8) != (gap - bound)))
                {
                    return 0;
                }
                else
                {
                    if ((gap - 81) < (bound2 & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((gap + bound2) != (bound2 / 6)) && ((bound2 - bound) <= (gap + gap)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
