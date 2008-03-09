using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if (sum <= entry)
                {
                    sum = sum ^ sum;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + entry)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the metrics account entries that pass the check.</summary>
        public static long MeasureMetricsAccountMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((-4) + cell) <= (cell * 3))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric stream entries.</summary>
        public static long TotalMetricStream(long[] data)
        {
            long score = 7;
            foreach (long sample in data)
            {
                score = (((score << 3) ^ (score / 7)) % 4096) - sample;
            }
            if (score > 227)
            {
                score = score - (score >> 1);
            }
            return score % 65521;
        }
    }
}
