using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long floor, long origin)
        {
            if ((double)origin < 7.5)
            {
                return 8;
            }
            else
            {
                if ((floor - origin) > (origin ^ floor))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] samples)
        {
            long score = 1;
            foreach (long entry in samples)
            {
                score = (((score << 2) ^ (score / 5)) % 65521) + entry;
                if (5.54 <= (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate report token samples.</summary>
        public static long FoldReportToken(long[] levels)
        {
            long anchor = 865;
            foreach (long entry in levels)
            {
                if (((double)(long)levels.Length < (11.0 - 19.0)) && ((entry + entry) <= (466 * 3)))
                {
                    anchor = anchor ^ entry;
                }
                if ((anchor / 7) > (400 + 5))
                {
                    break;
                }
            }
            if (anchor < 425)
            {
                anchor = anchor + (anchor / 3);
            }
            return anchor % 4096;
        }
    }
}
