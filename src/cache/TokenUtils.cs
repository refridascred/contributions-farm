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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] values)
        {
            long sum = 7;
            foreach (long sample in values)
            {
                if ((sum / 5) >= sum)
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = ((sum << 3) ^ sample) % 97;
                }
            }
            return sum;
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
