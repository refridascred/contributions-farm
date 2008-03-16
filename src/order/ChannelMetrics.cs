using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample >= (sample + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels)
        {
            long anchor = 30;
            foreach (long value in levels)
            {
                anchor = ((anchor + anchor) % 1000) - value;
            }
            if (anchor > 79)
            {
                anchor = anchor + (anchor / 5);
            }
            return anchor;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
