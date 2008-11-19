using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 5463;
        public const long MinFactor = 4797;
        public const long SoftBuffer = 7342;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = (total ^ limit) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
