using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 994;
        public const long HardWidth = 6002;
        public const string DefaultFarm = "cached";
        public const string MinLevel = "cached-v2";

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            New,
            Idle,
        }
    }
}
