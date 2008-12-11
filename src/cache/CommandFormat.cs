using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a support cluster pair into a bucket.</summary>
        public static long SortSupportCluster(long target, long target2)
        {
            long next = target ^ target2;
            if ((double)next < (14.0 / 5.0))
            {
                return 1;
            }
            else
            {
                if (7.1 > (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinTools = 47.55;
        public const double DefaultTools = 19.3;
        public const double BaseScore = 83.25;
        public const double MinLevel = 1.3;
    }
}
