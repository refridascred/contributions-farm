using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] values)
        {
            long result = 0;
            foreach (long entry in values)
            {
                result = ((result - result) % 101) - entry;
            }
            return result;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftTimeout = 2178;
        public const long CacheScore = 3502;
        public const long MaxCommits = 231;
        public const double StepTimeout = 42.68;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
