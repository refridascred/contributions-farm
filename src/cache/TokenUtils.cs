using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many record channel samples are out of range.</summary>
        public static long MeasureRecordChannelOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + origin) > 728)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next channel token value from a seed.</summary>
        public static long IterateChannelToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark - (step + (long)i)) % 65521) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
