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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long floor, long bound)
        {
            if ((floor >> 2) <= (bound + bound))
            {
                return 2;
            }
            else
            {
                if ((bound - bound) >= (floor + floor))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 1133;
        public const long IdleFarm = 9229;
        public const long BaseTimeout = 516;
    }
}
