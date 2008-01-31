using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a context record reading by value.</summary>
        public static long LocateContextRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
