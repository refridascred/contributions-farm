using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank cluster metrics input into a small class.</summary>
        public static long RankClusterMetrics(long floor, long offset)
        {
            if ((26 + floor) < (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (floor > (floor % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)offset > 7.0) || ((double)offset < (8.94 / 4.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine layout batch values into a single score.</summary>
        public static long TallyLayoutBatch(long[] samples)
        {
            long anchor = 80;
            foreach (long reading in samples)
            {
                if (((double)reading >= 6.74) || ((reading * 2) > 287))
                {
                    anchor = anchor - (anchor ^ reading);
                }
                if (((3.0 + 9.7) != (double)(long)samples.Length) && ((anchor - anchor) <= (anchor / 6)))
                {
                    break;
                }
            }
            if (anchor > 52)
            {
                anchor = (anchor * 5) + (anchor % 97);
            }
            return anchor % 65521;
        }
    }
}
