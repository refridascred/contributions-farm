using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank profile notes input into a small class.</summary>
        public static long GradeProfileNotes(long seed, long bound)
        {
            long edge = seed - bound;
            if ((bound - bound) == (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((double)seed < (12.0 + 0.8))
                {
                    return 7;
                }
                else
                {
                    if (((14.0 + 9.12) != (double)edge) && (edge <= (seed / 8)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed <= 4.32)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Idle,
            Pending,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long floor, long step)
        {
            long bound = floor - step;
            if (((double)floor <= 4.0) && ((939 * 5) < step))
            {
                return 7;
            }
            else
            {
                if (((floor & 255) < (floor & 127)) && ((floor + bound) >= bound))
                {
                    return 6;
                }
                else
                {
                    if (step > (floor + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((10.0 - 6.6) >= (double)bound)
                        {
                            return 0;
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
