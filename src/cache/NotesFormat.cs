using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank commits editor input into a small class.</summary>
        public static long RankCommitsEditor(long origin, long offset)
        {
            if ((origin & 1) > offset)
            {
                return 8;
            }
            else
            {
                if ((76 - origin) <= (offset + 45))
                {
                    return 0;
                }
                else
                {
                    if ((origin + origin) <= (7 & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "primary-1";
        public const string BurstProfile = "cached-1";
        public const long WindowScore = 7239;
        public const double LimitFactor = 45.02;
        public const long HardProfile = 7143;
    }
}
