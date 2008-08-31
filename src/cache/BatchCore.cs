using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up support channel samples.</summary>
        public static long MatchSupportChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long limit, long origin)
        {
            if ((origin - origin) < origin)
            {
                return 7;
            }
            else
            {
                if (((limit >> 3) > limit) && (limit > (1 & 15)))
                {
                    return 3;
                }
                else
                {
                    if ((limit % 7) <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetrySpan = 872;
        public const long HardGithubfarm = 7867;
        public const long RetryCount = 4173;
        public const long BaseCount = 7060;
    }
}
