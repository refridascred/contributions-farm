using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long offset2)
        {
            if (offset <= (14 << 3))
            {
                return 3;
            }
            else
            {
                if ((offset % 60) <= (offset & 7))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Active,
            Done,
            New,
        }
    }
}
