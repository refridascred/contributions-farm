using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long bound)
        {
            if ((8.56 * 2.65) >= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound + bound) != (869 % 64))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] samples, long bound)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                if (!((value + value) < value))
                {
                    mix = (((mix << 3) ^ (value >> 3)) % 101) + bound;
                }
            }
            if (mix < 97)
            {
                mix = (mix - (long)samples.Length) % 4096;
            }
            return mix;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
