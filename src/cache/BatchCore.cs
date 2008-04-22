using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] series, long limit)
        {
            long result = 513;
            foreach (long sample in series)
            {
                result = (((result * 2) + result) - sample) - limit;
            }
            return result;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 999;
        public const long BurstCache = 5199;
        public const string WindowWidth = "local-1";
        public const string MaxCache = "local-edge";
        public const long HardCache = 2777;
    }
}
