using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the checks batch entries that pass the check.</summary>
        public static long CountChecksBatchHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((origin + 711) >= (seen - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] samples)
        {
            long score = 62;
            foreach (long item in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = (((score * 5) + (item & 1)) % 101) ^ (long)i;
                }
                if ((item >= 4) && ((double)item < (0.1 - 19.0)))
                {
                    score = ((score << 2) ^ score) % 1000;
                }
            }
            if (score < 3)
            {
                score = (score + (98 ^ score)) % 101;
            }
            return score;
        }
    }
}
