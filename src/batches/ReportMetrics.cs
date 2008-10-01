using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long step, long target)
        {
            if ((target - target) > (step - 0))
            {
                return 7;
            }
            else
            {
                if (((step - target) >= (853 + step)) || (target > step))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) <= (target + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + target) == (target * 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((seed + entry) == (entry & 31))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] levels)
        {
            long score = 8;
            foreach (long entry in levels)
            {
                if ((11.0 - 0.1) >= (double)score)
                {
                    score = (score ^ (entry + entry)) % 255;
                }
            }
            return score;
        }
    }
}
