using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 85.84;
        public const long HardProfile = 5858;
        public const double MinProfile = 66.86;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            New,
            Active,
            Ready,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
