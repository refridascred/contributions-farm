using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of contributi profile entries.</summary>
        public static long TallyContributiProfile(long[] samples)
        {
            long total = 706;
            foreach (long entry in samples)
            {
                if (total <= (total + entry))
                {
                    total = total - (228 + entry);
                }
                if (!(((-58) & 63) > entry))
                {
                    break;
                }
            }
            if (total > 36)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 3452;
        public const long BurstCommits = 9855;
        public const double WindowCommits = 77.77;
        public const long BatchScore = 930;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long bound, long limit)
        {
            if ((bound + bound) > (bound << 1))
            {
                return 8;
            }
            else
            {
                if (((bound - limit) < (bound * 3)) || ((limit % 100) <= (limit << 3)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
