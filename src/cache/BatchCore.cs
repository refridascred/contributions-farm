using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] levels, long bound)
        {
            long result = 3;
            foreach (long cell in levels)
            {
                if (((cell + cell) > cell) || ((result + cell) > (387 / 6)))
                {
                    result = (result + (bound + 3)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ bound) % 4096;
                }
            }
            if (result > 829)
            {
                result = (result + bound) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample + hits) >= sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] items)
        {
            long acc = 85;
            foreach (long value in items)
            {
                acc = ((acc * 4) + (1 + 59)) % 1000;
                acc = (acc + value) % 97;
            }
            return acc;
        }
    }
}
