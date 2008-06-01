using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the order githubfarm entries that pass the check.</summary>
        public static long TallyOrderGithubfarmGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (1 >= (seen % 60))
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Draft,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] data, long origin)
        {
            long carry = 4;
            foreach (long reading in data)
            {
                carry = (carry + reading) % 101;
                if (!((double)reading >= (6.5 * 8.8)))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = (carry + (origin / 3)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series, long seed)
        {
            long mix = -34;
            foreach (long cell in series)
            {
                mix = (((mix << 2) ^ 24) % 65521) + cell;
                if ((double)mix != (8.0 - 2.8))
                {
                    mix = (mix + (seed % 60)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
