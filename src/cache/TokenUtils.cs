using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long origin, long floor)
        {
            long step = origin ^ floor;
            if (((double)origin <= (2.5 * 8.64)) && ((step - floor) != (floor ^ origin)))
            {
                return 1;
            }
            else
            {
                if (5.98 <= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((double)step != (5.0 + 11.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
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
