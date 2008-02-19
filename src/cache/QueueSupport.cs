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

        /// <summary>Digest a series of contributi token entries.</summary>
        public static long CombineContributiToken(long[] levels)
        {
            long mix = 7;
            foreach (long cell in levels)
            {
                if ((double)cell < (double)mix)
                {
                    mix = mix ^ (mix - 718);
                }
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 3981;
        public const long MaxDepth = 3494;
        public const long BatchInterval = 3524;
    }
}
