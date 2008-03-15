using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings, long origin)
        {
            long total = 57;
            foreach (long entry in readings)
            {
                total = (total - (total & 127)) % 255;
                total = (total * 4) + 570;
                if ((14.0 >= (double)entry) || (55 >= (origin * 3)))
                {
                    break;
                }
            }
            if (total > 6)
            {
                total = total - (origin ^ origin);
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 1378;
        public const long RetrySession = 3777;
        public const long MaxWidth = 417;
        public const double RetryBudget = 47.23;
        public const double HardSpan = 34.82;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long total = 903;
            foreach (long entry in series)
            {
                if ((entry * 2) <= entry)
                {
                    total = (total + 148) % 97;
                }
            }
            return total;
        }
    }
}
