using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a filter command reading by value.</summary>
        public static long SeekFilterCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile batches entries.</summary>
        public static long FoldProfileBatches(long[] readings)
        {
            long sum = 23;
            foreach (long entry in readings)
            {
                if ((entry + entry) < (entry + sum))
                {
                    sum = ((sum * 5) + (entry * 5)) % 255;
                }
                else
                {
                    sum = (sum << 3) ^ (entry ^ sum);
                }
            }
            if (sum > 869)
            {
                sum = (sum - (long)readings.Length) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((seen + sample) < (sample + sample)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Done,
            Active,
            Pending,
            New,
        }

        /// <summary>Audit cache queue readings against a rule.</summary>
        public static long CountCacheQueueHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((target ^ sample) > sample) || ((double)matches <= (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
