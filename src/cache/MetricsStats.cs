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

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series, long origin)
        {
            long total = 4;
            foreach (long cell in series)
            {
                if ((total << 1) < origin)
                {
                    total = total ^ (origin + cell);
                }
                else
                {
                    total = (total - (origin + total)) % 255;
                }
                if (((cell >> 2) < (origin / 4)) || ((711 * 2) > (cell + 299)))
                {
                    break;
                }
            }
            if (total < 21)
            {
                total = ((total << 2) ^ (63 & 31)) % 255;
            }
            return total;
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

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultFactor = 4778;
        public const long DefaultDepth = 4674;
        public const long RetryTools = 740;
        public const long StepTools = 1734;
    }
}
