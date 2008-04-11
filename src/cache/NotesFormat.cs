using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 75.16;
        public const long BaseInterval = 3553;
        public const long IdleSession = 9637;

        /// <summary>Grade a entry counter value against two limits.</summary>
        public static long RankEntryCounter(long step, long step2)
        {
            long edge = step ^ step2;
            if ((step2 + step) == (edge * 2))
            {
                return 8;
            }
            else
            {
                if (((edge + step) <= (edge >> 5)) && ((0 - step) > (step2 - edge)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
