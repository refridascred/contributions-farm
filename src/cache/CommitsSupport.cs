using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum * 4) + (long)i;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchLevel = 23.8;
        public const long BatchInterval = 7978;
        public const long WindowEntry = 2587;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((1.8 + 9.83) > (double)count)
                {
                    count = ((count + 1) ^ value) - seed;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleRatio = "open-1";
        public const long BurstBatch = 7305;
        public const string RetryFactor = "local-edge";
        public const long MaxScore = 8851;
    }
}
