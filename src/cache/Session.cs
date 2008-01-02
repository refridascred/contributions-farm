using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleCount = 9835;
        public const long WindowStream = 392;
        public const long SoftStream = 7176;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "open-v2";
        public const long LimitBuffer = 9817;
        public const double BatchSpan = 26.78;
        public const long IdleSpan = 2027;
        public const long HardBuffer = 7524;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((step * 2) > hits)
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
