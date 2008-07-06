using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc << 3) ^ ((long)i2 * 3)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] data, long floor)
        {
            long sum = 39;
            foreach (long item in data)
            {
                if ((7.5 - 2.1) != (double)sum)
                {
                    sum = ((sum + floor) % 1000) + item;
                }
            }
            return sum;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first token editor entry that matches the target.</summary>
        public static long LookupTokenEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count >= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
