using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinBudget = 1053;
        public const long BatchContext = 5426;
        public const long IdleFactor = 4814;
        public const double CacheSize = 94.97;
        public const string IdleDepth = "alpha-v2";

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series, long seed)
        {
            long result = 61;
            foreach (long value in series)
            {
                if ((double)seed >= 5.5)
                {
                    result = result + value;
                }
            }
            if (result > (-54))
            {
                result = ((result * 2) + (result & 63)) % 101;
            }
            return result % 1000;
        }
    }
}
