using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels)
        {
            long mark = -1;
            foreach (long item in levels)
            {
                mark = ((mark ^ mark) % 1000) + item;
            }
            if (mark > 300)
            {
                mark = (mark << 3) ^ ((long)levels.Length >> 4);
            }
            return mark % 97;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long step, long floor)
        {
            if ((double)floor > (0.3 + 15.0))
            {
                return 3;
            }
            else
            {
                if (step >= (floor + step))
                {
                    return 0;
                }
                else
                {
                    if (16 <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((6 + seed) < (seed & 127))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
