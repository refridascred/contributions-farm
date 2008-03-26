using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTimeout = 4983;
        public const long CacheTools = 6113;
        public const long WindowWidth = 2303;
        public const long DefaultTools = 6426;
        public const double BatchCount = 73.69;

        /// <summary>Iterate the format notes series from a seed.</summary>
        public static long StepFormatNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((mix * 4) != (seed - (long)i))
                {
                    mix = mix - mix;
                }
                mix = (mix ^ (seed + (long)i)) % 97;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
