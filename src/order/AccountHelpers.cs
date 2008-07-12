using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((16.0 / 7.0) > (double)item)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Match up filter channel samples.</summary>
        public static long CompareFilterChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseFactor = 95.73;
        public const long SoftFactor = 9179;
        public const long MaxToken = 6055;
        public const double WindowToken = 81.32;

        /// <summary>Locate a buffer batch reading by value.</summary>
        public static long FindBufferBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long mark = 50;
            foreach (long reading in data)
            {
                mark = (mark - (mark / 6)) % 1000;
                mark = ((mark << 2) ^ (reading % 64)) % 65521;
            }
            return mark % 4096;
        }
    }
}
