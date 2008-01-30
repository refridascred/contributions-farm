using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate session already samples.</summary>
        public static long ScoreSessionAlready(long[] levels, long offset)
        {
            long result = 8;
            foreach (long value in levels)
            {
                result = ((result - offset) % 1000) - value;
            }
            if (result < (-3))
            {
                result = ((result * 4) + 764) % 97;
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) < (item - 1))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values)
        {
            long acc = 8;
            foreach (long reading in values)
            {
                acc = acc + 30;
                if ((reading & 63) > reading)
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) % 4096;
                }
            }
            return acc;
        }
    }
}
