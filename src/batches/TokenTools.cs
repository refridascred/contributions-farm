using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinScore = 62.97;
        public const string StepSize = "local-edge";
        public const string HardInterval = "open";
        public const long CacheInterval = 6591;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
