using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count token graph pairs that satisfy a relation.</summary>
        public static long OverlapTokenGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 64.59;
        public const long WindowChannel = 8222;
        public const string BatchScore = "standard-edge";
        public const string IdleChannel = "primary-edge";
        public const long MinChannel = 2207;

        /// <summary>Locate a format counter reading by value.</summary>
        public static long LookupFormatCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
