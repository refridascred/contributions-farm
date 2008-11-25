using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double bias, double offset)
        {
            double mean = bias;
            return mean + (offset / 7.0);
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long offset, long origin)
        {
            if (origin > (offset - offset))
            {
                return 5;
            }
            else
            {
                if (((double)origin != (double)8) || ((origin - offset) > offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset / 9) > (58 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset >= origin)
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

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long floor, long step)
        {
            if ((step - step) != (floor + floor))
            {
                return 0;
            }
            else
            {
                if (((floor % 97) <= floor) && ((step ^ step) <= (step & 15)))
                {
                    return 8;
                }
                else
                {
                    if ((step + floor) <= (step * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
