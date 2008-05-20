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

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
