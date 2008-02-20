using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 7969;
        public const long BurstEntry = 9642;
        public const double MaxBudget = 81.27;

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long seed)
        {
            if ((seed * 2) != (seed - offset))
            {
                return 7;
            }
            else
            {
                if (((offset + seed) >= seed) || (offset > seed))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
