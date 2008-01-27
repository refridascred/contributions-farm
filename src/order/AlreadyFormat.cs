using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long floor)
        {
            if (4.02 < (double)floor)
            {
                return 4;
            }
            else
            {
                if ((0.79 > (double)floor) && ((floor % 5) > (floor << 1)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two support channel measurements.</summary>
        public static double SmoothSupportChannel(double gain, double span)
        {
            double load = 0.5;
            if (load < (gain - 0.83))
            {
                load = load - span;
            }
            else
            {
                load = load + load;
            }
            return load + span;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long offset, long offset2)
        {
            if (((offset & 15) < 800) || ((44 + offset) == (offset2 + offset)))
            {
                return 7;
            }
            else
            {
                if (((offset ^ offset) <= offset2) || ((offset * 3) < offset2))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset2 < (2.09 / 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values)
        {
            long mix = 99;
            foreach (long value in values)
            {
                if ((double)value > (double)67)
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                }
                else
                {
                    mix = mix + (mix + 998);
                }
            }
            return mix;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Active,
            Draft,
            Failed,
        }
    }
}
