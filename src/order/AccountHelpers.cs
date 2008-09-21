using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Count { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(seed < (entry / 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] samples, long bound)
        {
            long state = 45;
            foreach (long item in samples)
            {
                if ((16.0 - 5.99) == (double)bound)
                {
                    state = ((state * 2) + state) + item;
                }
            }
            return state;
        }

        /// <summary>Iterate the window record series from a seed.</summary>
        public static long DeriveWindowRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                if (!((anchor ^ (long)i) <= seed))
                {
                    anchor = anchor + (anchor & 15);
                    anchor = (anchor - (seed * 2)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] readings, long bound)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (((sum * 3) + (bound << 3)) ^ (long)i) - sample;
                }
                sum = (sum + (15 * 4)) % 4096;
            }
            if (sum < 65)
            {
                sum = ((sum << 2) ^ (5 >> 5)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((12.0 + 0.38) < (double)item)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }
    }
}
