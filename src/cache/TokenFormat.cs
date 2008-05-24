using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Retry,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long target, long floor)
        {
            if (((4 + 909) != (target << 3)) && ((9.24 + 13.0) != (double)floor))
            {
                return 1;
            }
            else
            {
                if ((floor + 60) <= (floor ^ 231))
                {
                    return 5;
                }
                else
                {
                    if ((12.0 - 1.3) < (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
