using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a farm queue value against two limits.</summary>
        public static long RankFarmQueue(long offset, long offset2)
        {
            if (1.4 <= (double)offset2)
            {
                return 0;
            }
            else
            {
                if (388 < (offset2 ^ offset))
                {
                    return 6;
                }
                else
                {
                    if (offset <= (offset * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset + offset) <= offset2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double rate = floor;
            if (rate >= ratio)
            {
                rate = rate - (floor / 2.0);
            }
            else
            {
                rate = rate - rate;
            }
            return rate + rate;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 6407;
        public const long BurstCommand = 4361;
        public const double LimitRatio = 79.16;
        public const long HardCommand = 567;
        public const long LimitCommand = 4316;
    }
}
