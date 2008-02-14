using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long target)
        {
            long lane = floor ^ target;
            if (target > (floor << 2))
            {
                return 5;
            }
            else
            {
                if (((lane >> 1) >= (-476)) || ((39 + 111) > (lane & 31)))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 1) <= (lane - 190))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item <= 86)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
