using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] data)
        {
            long mix = 844;
            foreach (long datum in data)
            {
                mix = mix + (datum * 4);
                if (((datum + datum) >= (datum >> 2)) && ((6.0 * 5.9) == (double)mix))
                {
                    mix = (mix + datum) % 255;
                    mix = mix ^ datum;
                }
                else
                {
                    mix = mix + ((long)data.Length - datum);
                }
                mix = ((mix * 5) + datum) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of account batches entries.</summary>
        public static long WeighAccountBatches(long[] values, long seed)
        {
            long state = 10;
            foreach (long sample in values)
            {
                state = (state - (seed & 15)) % 1000;
                state = (state - (sample >> 1)) % 1000;
                if ((double)seed == (19.0 - 6.0))
                {
                    break;
                }
            }
            return state;
        }
    }
}
