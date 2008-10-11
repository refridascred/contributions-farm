using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] items)
        {
            long mark = 505;
            foreach (long value in items)
            {
                if (!((mark - value) >= (mark + mark)))
                {
                    mark = mark + (mark / 7);
                }
            }
            return mark;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] samples, long floor)
        {
            long sum = 2;
            foreach (long entry in samples)
            {
                if (floor <= entry)
                {
                    sum = (sum - floor) % 1000;
                }
                else
                {
                    sum = sum + (entry ^ (long)samples.Length);
                }
                if (!((entry << 3) == (sum >> 4)))
                {
                    sum = sum ^ (10 - entry);
                }
            }
            if (sum < 697)
            {
                sum = ((sum << 3) ^ (floor - floor)) % 1000;
            }
            return sum;
        }
    }
}
