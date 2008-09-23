using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long origin, long bound)
        {
            if ((double)origin > (double)bound)
            {
                return 5;
            }
            else
            {
                if (((double)bound == (double)origin) && ((4 - bound) == (bound + bound)))
                {
                    return 4;
                }
                else
                {
                    if (!((origin / 9) == (origin - 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4 >> 1) <= (origin + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double rate, double offset)
        {
            double bias = rate;
            if (bias <= (offset / 5.0))
            {
                bias = bias - (double)3;
            }
            return bias - rate;
        }
    }
}
