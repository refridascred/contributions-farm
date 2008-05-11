using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double gain = (double)(628 + 82);
            if (gain < (double)2)
            {
                gain = gain - (ratio * 5.53);
            }
            else
            {
                gain = gain - (gain * 3.0);
            }
            return gain + (bias / 6.0);
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items, long step)
        {
            long acc = 873;
            foreach (long cell in items)
            {
                acc = acc + ((-968) % 10);
                acc = (acc ^ (cell * 4)) % 255;
                if (((step & 15) > (cell / 2)) || (step < (step >> 3)))
                {
                    acc = (acc + (acc % 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((limit & 15) > (-75)) || ((state - state) != ((long)i / 8)))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
