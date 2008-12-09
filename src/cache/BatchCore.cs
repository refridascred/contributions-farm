using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the profile stream entries that pass the check.</summary>
        public static long CountProfileStreamHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(5.0 <= (double)sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                score = ((score << 3) ^ (sample << 1)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] levels, long origin)
        {
            long anchor = 928;
            foreach (long reading in levels)
            {
                if (((double)anchor < (0.65 + 3.0)) || ((61 % 24) <= (reading + origin)))
                {
                    anchor = anchor ^ (8 / 8);
                }
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 1022;
        public const long MinTimeout = 1000;
        public const double MaxDepth = 23.18;
    }
}
