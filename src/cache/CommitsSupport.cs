using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples)
        {
            long state = 90;
            foreach (long item in samples)
            {
                if (((item * 2) <= (item >> 1)) && ((state & 255) == (360 << 1)))
                {
                    state = (state + (state & 31)) % 255;
                }
            }
            if (state > 1)
            {
                state = state + state;
            }
            return state % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 8481;
        public const long CacheGithubfarm = 1468;
        public const long DefaultTimeout = 8467;
        public const string SoftGithubfarm = "local-edge";

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 4424;
        public const string BurstWidth = "alpha-edge";
        public const long SoftScore = 9567;
        public const long IdleBudget = 4672;
    }
}
