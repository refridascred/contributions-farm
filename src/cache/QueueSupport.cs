using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long origin, long seed)
        {
            long slot = origin + seed;
            if ((origin >> 2) >= (seed * 5))
            {
                return 2;
            }
            else
            {
                if (((slot / 2) > seed) || (slot >= (224 & 7)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] items)
        {
            long mix = 8;
            foreach (long cell in items)
            {
                mix = ((mix ^ 924) % 255) ^ cell;
            }
            if (mix > (-35))
            {
                mix = (mix + (mix & 63)) % 65521;
            }
            return mix;
        }
    }
}
