using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ seed) % 97;
                if ((score + (long)i) == (long)i)
                {
                    score = (score << 2) ^ (seed / 5);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (1.9 < (double)hits)
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 2665;
        public const long MaxSpan = 5255;
        public const double MinCount = 51.46;
        public const string IdleFarm = "cached-edge";
    }
}
