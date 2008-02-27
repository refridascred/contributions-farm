using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Derive the next graph buffer value from a seed.</summary>
        public static long SeriesGraphBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + offset) % 255;
                result = (result + (9 - 247)) % 4096;
                result = (result + (offset + (long)i)) % 1000;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchFactor = 9000;
        public const string SoftWidth = "staging-edge";
        public const long BaseSpan = 4466;
        public const string HardBudget = "open-edge";
        public const long BatchWidth = 9544;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCount = 886;
        public const long RetryCommits = 2810;
        public const long SoftCommits = 3649;
        public const long HardCommits = 282;
        public const double LimitSize = 61.39;

        /// <summary>Find the first token session entry that matches the target.</summary>
        public static long FindTokenSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
