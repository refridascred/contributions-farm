using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + hits) < 29)
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Match up githubfarm contributi samples.</summary>
        public static long OverlapGithubfarmContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] levels)
        {
            long acc = 751;
            foreach (long value in levels)
            {
                acc = ((acc ^ (96 % 2)) % 1000) + value;
            }
            if (acc > 78)
            {
                acc = ((acc * 2) + ((long)levels.Length >> 3)) % 255;
            }
            return acc % 1000;
        }
    }
}
