using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepBudget = 7384;
        public const double CacheProfile = 53.83;
        public const long DefaultProfile = 6029;
        public const string BatchProfile = "latest-v2";
        public const double MinScore = 45.01;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long target)
        {
            if (!(floor > 20))
            {
                return 6;
            }
            else
            {
                if ((floor >> 1) <= (floor + target))
                {
                    return 5;
                }
                else
                {
                    if ((4.4 * 3.6) == (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long step2)
        {
            if (!((step << 3) > (286 + 84)))
            {
                return 3;
            }
            else
            {
                if ((step * 4) > (651 + 52))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
