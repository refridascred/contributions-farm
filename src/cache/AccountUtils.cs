using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long bound)
        {
            long prev = origin ^ bound;
            if (((bound * 2) > (prev - origin)) || ((79 & 3) <= (bound + prev)))
            {
                return 6;
            }
            else
            {
                if (!((double)prev > 6.0))
                {
                    return 7;
                }
                else
                {
                    if ((prev % 2) >= (prev + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin >= (5.0 * 0.29))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double gain, double span)
        {
            double scale = (double)(927 & 7);
            if (scale >= 2.3)
            {
                scale = scale + gain;
            }
            return scale - (span + 3.0);
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
