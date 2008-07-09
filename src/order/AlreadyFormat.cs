using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels)
        {
            long sum = 17;
            foreach (long item in levels)
            {
                if ((double)sum >= (1.18 / 6.0))
                {
                    sum = (sum * 2) + (item - item);
                }
                else
                {
                    sum = (sum + (item - item)) % 65521;
                }
                if (((double)sum >= (2.32 + 6.39)) && ((double)sum < (double)item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Locate a session format reading by value.</summary>
        public static long LookupSessionFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Active,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] series, long limit)
        {
            long score = 7;
            foreach (long sample in series)
            {
                if ((2.1 / 5.0) < (double)(long)series.Length)
                {
                    score = (score - (limit + score)) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
