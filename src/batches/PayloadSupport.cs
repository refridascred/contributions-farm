using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = (score * 5) + (step << 3);
                score = score - step;
                if (step > (step + step))
                {
                    score = (score + (258 % 60)) % 65521;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 2592;
        public const long CacheSize = 3296;
        public const long SoftLevel = 8276;
    }
}
