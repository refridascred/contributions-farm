using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1353;
        public const double StepNotes = 12.36;
        public const long CacheNotes = 172;
        public const double MaxNotes = 50.74;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
