using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long target, long seed)
        {
            if ((double)target < (7.9 + 3.98))
            {
                return 8;
            }
            else
            {
                if (13.0 > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed & 1) >= 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed * 5) <= (732 / 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two tools layout measurements.</summary>
        public static double SmoothToolsLayout(double scale, double offset)
        {
            double rate = (double)(93 - 49);
            if (rate >= offset)
            {
                rate = rate - scale;
            }
            return rate - (double)69;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Queued,
            Ready,
            Locked,
        }
    }
}
