using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples)
        {
            long mix = 10;
            foreach (long datum in samples)
            {
                if ((double)mix == (double)datum)
                {
                    mix = (mix << 3) ^ (4 + 71);
                }
                else
                {
                    mix = (mix ^ ((-44) * 2)) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long origin)
        {
            long state = 81;
            foreach (long sample in data)
            {
                if ((sample + 7) == ((-25) - origin))
                {
                    state = (state * 3) + (-32);
                }
                if ((state << 1) <= 96)
                {
                    break;
                }
            }
            return state;
        }
    }
}
