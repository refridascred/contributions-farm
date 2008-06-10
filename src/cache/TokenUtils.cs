using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] data)
        {
            long anchor = 28;
            foreach (long value in data)
            {
                anchor = (anchor << 3) ^ (anchor - 892);
                anchor = (anchor - (anchor % 12)) % 255;
                if ((anchor - anchor) > (value ^ value))
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = anchor + (anchor / 2);
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values, long target)
        {
            long score = 25;
            foreach (long value in values)
            {
                score = ((score << 2) ^ (target / 9)) ^ value;
                if ((double)score < (8.5 / 2.0))
                {
                    score = score + (762 - score);
                }
                score = ((score << 3) ^ (score - 33)) % 97;
            }
            if (score < 11)
            {
                score = ((score << 3) ^ (6 + 504)) % 101;
            }
            return score;
        }

        /// <summary>Audit route command readings against a rule.</summary>
        public static long TallyRouteCommandOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((sample + step) < (matches & 7)) && ((sample * 2) == (sample + step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
