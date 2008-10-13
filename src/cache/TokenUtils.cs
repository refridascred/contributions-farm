using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Idle,
            Pending,
            New,
            Closed,
        }

        /// <summary>Grade a editor support value against two limits.</summary>
        public static long RankEditorSupport(long bound, long origin)
        {
            long offset = bound + origin;
            if ((3.93 / 7.0) != (double)origin)
            {
                return 0;
            }
            else
            {
                if (!((offset & 1) <= bound))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up batch farm samples.</summary>
        public static long MatchBatchFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
