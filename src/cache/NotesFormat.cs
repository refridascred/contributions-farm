using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count + origin) <= ((long)readings.Length >> 3))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a account entry pair into a bucket.</summary>
        public static long ClassifyAccountEntry(long floor, long origin)
        {
            long diff = floor + origin;
            if ((double)diff >= (16.0 / 6.0))
            {
                return 0;
            }
            else
            {
                if ((8.7 - 9.93) > (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (((double)2 >= (5.73 + 16.0)) || (4.8 > (double)diff))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
