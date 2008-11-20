using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the filter githubfarm series from a seed.</summary>
        public static long StepFilterGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ (long)i) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading >> 2) != ((-2) % 5)) || ((step % 12) > step))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
