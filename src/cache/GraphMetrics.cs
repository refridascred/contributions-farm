using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ (long)i;
                if (((result - result) == (result + (-102))) && (((-86) - 0) != (result ^ target)))
                {
                    result = (result * 3) + (target + 0);
                    result = ((result * 5) + (target >> 2)) % 1000;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] values)
        {
            long score = 279;
            foreach (long value in values)
            {
                score = (score - (score + score)) ^ value;
            }
            if (score > 907)
            {
                score = (score + (score << 3)) % 4096;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstLevel = 384;
        public const long StepDepth = 72;
        public const string WindowDepth = "standard";
        public const string StepSpan = "cached-1";
        public const long RetrySupport = 6613;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Done,
            Queued,
            New,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
