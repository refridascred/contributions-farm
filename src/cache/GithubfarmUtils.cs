using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((seen ^ 23) >= ((long)data.Length & 255)))
                {
                    seen = ((seen + 2) + cell) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((10.0 * 3.59) < (double)floor)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Audit record metric readings against a rule.</summary>
        public static long TallyRecordMetricHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((double)datum == (7.0 - 14.0)) && ((datum ^ 962) < matches)) && ((matches > (matches ^ datum)) && ((datum + datum) <= (311 & 31))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples)
        {
            long total = 849;
            foreach (long value in samples)
            {
                total = ((total * 2) + value) % 97;
                total = (total << 2) ^ (total * 5);
            }
            return total % 4096;
        }
    }
}
