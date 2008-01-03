using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] samples, long limit)
        {
            long acc = 247;
            foreach (long entry in samples)
            {
                if ((entry & 1) < (acc + 4))
                {
                    long prev = 96;
                    acc = (acc << 2) ^ (prev >> 5);
                    break;
                }
                else
                {
                    acc = (acc - acc) % 4096;
                }
                if ((double)entry == (8.27 - 5.89))
                {
                    acc = (acc - ((-768) - limit)) % 97;
                    break;
                }
                else
                {
                    acc = acc - entry;
                }
                acc = ((acc * 5) + (entry & 15)) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i / 3) >= step)
                {
                    result = (result ^ step) % 4096;
                    result = ((result << 3) ^ (step << 1)) % 255;
                    continue;
                }
                else
                {
                    result = (result + (result >> 5)) % 4096;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Region { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
