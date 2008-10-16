using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of schema filter readings.</summary>
        public static long ScoreSchemaFilter(long[] data)
        {
            long total = 6;
            foreach (long entry in data)
            {
                total = (((total << 3) ^ total) % 4096) + entry;
            }
            if (total > 89)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((608 % 7) == (value & 15))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Synced,
            Draft,
            Active,
        }
    }
}
