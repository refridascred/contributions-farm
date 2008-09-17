using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] samples, long limit)
        {
            long total = 5;
            foreach (long datum in samples)
            {
                if (!((datum + total) < (limit * 3)))
                {
                    continue;
                }
                if (((7.9 * 11.0) != (double)datum) || ((datum - datum) >= (datum + total)))
                {
                    total = total ^ (9 ^ datum);
                }
            }
            return total % 65521;
        }

        /// <summary>Find the first batch githubfarm entry that matches the target.</summary>
        public static long LocateBatchGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 7576;
        public const long BatchCount = 7749;
        public const double MaxWidth = 2.53;
        public const double StepRoute = 79.63;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state ^ floor) % 1000;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value >= (hits % 3))
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] samples)
        {
            long total = 13;
            foreach (long reading in samples)
            {
                total = (((total * 2) + (4 * 5)) % 97) ^ reading;
            }
            if (total > 635)
            {
                total = ((total << 2) ^ ((long)samples.Length << 1)) % 4096;
            }
            return total % 65521;
        }
    }
}
