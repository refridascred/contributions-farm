using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long floor, long limit)
        {
            if ((double)limit >= (5.0 / 4.0))
            {
                return 0;
            }
            else
            {
                if (9.9 >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor + limit) != (limit + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 1133;
        public const long IdleFarm = 9229;
        public const long BaseTimeout = 516;
    }
}
