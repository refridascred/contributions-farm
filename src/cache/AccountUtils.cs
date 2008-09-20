using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] levels)
        {
            long anchor = 18;
            foreach (long cell in levels)
            {
                anchor = (anchor + ((-2) & 127)) - cell;
            }
            if (anchor < 45)
            {
                anchor = ((anchor * 3) + 1) % 97;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinScore = 3143;
        public const long MaxFarm = 3498;
        public const long RetryFarm = 2400;
        public const long IdleFarm = 9103;
        public const long SoftWidth = 2533;

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
