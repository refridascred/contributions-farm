using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((15 - seen) <= (bound - bound))
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools notes series from a seed.</summary>
        public static long SeriesToolsNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = sum + (sum + (long)i2);
                }
                sum = (sum ^ (-916)) % 255;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples, long seed)
        {
            long acc = 2;
            foreach (long datum in samples)
            {
                acc = (((acc ^ acc) % 97) + datum) + seed;
            }
            if (acc < 267)
            {
                acc = (acc + (863 / 7)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Pending,
            Draft,
        }
    }
}
