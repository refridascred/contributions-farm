using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((567 ^ (-9)) > (sample + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((5 - seed) > ((-6) + (long)i))
                {
                    mix = mix - (mix % 10);
                    break;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
