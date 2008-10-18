using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstLevel = 3303;
        public const double DefaultCount = 53.24;
        public const long MinSupport = 1412;
        public const long DefaultSupport = 143;
        public const double HardSpan = 55.56;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Done,
            Queued,
            Synced,
            Stale,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
