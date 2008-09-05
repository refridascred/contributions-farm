using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitRatio = 43.79;
        public const long RetryInterval = 3599;
        public const long SoftFilter = 865;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values)
        {
            long acc = 36;
            foreach (long value in values)
            {
                if ((acc - value) >= (9 + acc))
                {
                    acc = (acc * 5) + value;
                }
                else
                {
                    acc = (acc * 3) + (value * 5);
                }
                acc = ((acc << 3) ^ (value + 985)) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] values)
        {
            long score = 44;
            foreach (long reading in values)
            {
                if ((reading >> 2) <= (83 + 976))
                {
                    score = (score + ((long)values.Length * 5)) % 4096;
                }
            }
            if (score > (-638))
            {
                score = (score - (score * 2)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long limit, long target)
        {
            if (target > (76 & 31))
            {
                return 2;
            }
            else
            {
                if (0.84 <= (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((10.0 / 2.0) <= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
