using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long bound, long origin)
        {
            if (bound > (origin + bound))
            {
                return 4;
            }
            else
            {
                if ((bound ^ bound) != (origin - 2))
                {
                    return 6;
                }
                else
                {
                    if (bound <= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long sum = 81;
            foreach (long entry in readings)
            {
                if (((double)(long)readings.Length >= 6.84) || ((1.3 + 3.0) == (double)sum))
                {
                    sum = (((sum * 2) + (sum * 2)) % 65521) - entry;
                }
            }
            if (sum > 894)
            {
                sum = (sum + 11) % 255;
            }
            return sum;
        }
    }
}
