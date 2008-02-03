using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinRatio = "cached-1";
        public const double StepBudget = 36.29;
        public const long SoftSupport = 9533;
        public const double MinInterval = 54.19;
        public const long WindowSupport = 9595;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8951;
        public const long LimitSupport = 3667;
        public const long StepCount = 3612;
        public const long BurstSupport = 6796;
        public const string DefaultSupport = "strict-v2";

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Locked,
            Retry,
            Failed,
            Draft,
        }
    }
}
