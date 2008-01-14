using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up farm entry samples.</summary>
        public static long MatchFarmEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Synced,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 1374;
        public const double CacheFarm = 97.73;
        public const string MaxFarm = "primary-1";
    }
}
