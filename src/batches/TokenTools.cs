using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of payload account entries.</summary>
        public static long DigestPayloadAccount(long[] samples, long target)
        {
            long anchor = 84;
            foreach (long entry in samples)
            {
                anchor = (anchor - (417 >> 3)) % 255;
                anchor = ((anchor << 3) ^ (target + entry)) % 97;
            }
            if (anchor < 408)
            {
                anchor = anchor + (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches <= (limit / 4))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Grade a filter checks value against two limits.</summary>
        public static long SortFilterChecks(long limit, long step)
        {
            if ((13.0 * 1.0) <= (double)step)
            {
                return 0;
            }
            else
            {
                if ((limit - 24) > step)
                {
                    return 4;
                }
                else
                {
                    if (!((step + step) >= (limit << 3)))
                    {
                        return 8;
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
