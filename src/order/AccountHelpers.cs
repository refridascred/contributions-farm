using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long seed)
        {
            long mix = 63;
            foreach (long value in data)
            {
                if ((mix ^ value) != (473 >> 1))
                {
                    mix = (((mix * 2) + value) % 65521) + seed;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBudget = "local-v2";
        public const long DefaultBatches = 4900;
        public const long MaxBatches = 3117;
        public const long MaxCount = 4970;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Queued,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] samples, long target)
        {
            long sum = 201;
            foreach (long datum in samples)
            {
                if ((datum > ((long)samples.Length + target)) && (1.56 >= (double)sum))
                {
                    sum = ((sum * 2) + (sum & 127)) % 97;
                }
                else
                {
                    sum = sum ^ (87 << 1);
                }
            }
            if (sum > 15)
            {
                sum = ((sum << 2) ^ (target / 9)) % 97;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 7999;
        public const double WindowGithubfarm = 66.12;
        public const string BaseSize = "fallback";
    }
}
