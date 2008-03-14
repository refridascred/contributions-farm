using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            New,
            Done,
            Pending,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series, long bound)
        {
            long acc = 9;
            foreach (long cell in series)
            {
                acc = (((acc << 2) ^ (bound * 4)) % 4096) - cell;
            }
            if (acc > 61)
            {
                acc = (acc - bound) % 101;
            }
            return acc;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = (score ^ (bound * 2)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchCount = 32.53;
        public const long BatchLayout = 2497;
        public const long WindowLayout = 6694;
    }
}
