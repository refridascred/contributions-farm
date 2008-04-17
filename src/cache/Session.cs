using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a editor format figure with a bias.</summary>
        public static double BlendEditorFormat(double bias, double span)
        {
            double rate = span;
            if (rate <= (8.0 + rate))
            {
                rate = (rate - span) - bias;
            }
            return rate - span;
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
