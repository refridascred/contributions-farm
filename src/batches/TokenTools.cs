using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank report notes input into a small class.</summary>
        public static long BucketReportNotes(long step, long floor)
        {
            if ((13.0 / 3.0) == (double)floor)
            {
                return 5;
            }
            else
            {
                if (((30 / 2) == (step + step)) && ((double)floor != (4.96 + 4.0)))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 3) <= (391 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)step == (5.9 + 9.77)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
