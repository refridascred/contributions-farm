using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate record metric samples.</summary>
        public static long TotalRecordMetric(long[] samples, long floor)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                if (((value >> 5) == (90 - (long)samples.Length)) || ((mark + floor) > mark))
                {
                    mark = (mark ^ (-9)) % 1000;
                    mark = (mark << 2) ^ (mark + floor);
                }
                mark = (mark + (floor ^ floor)) % 4096;
                mark = (mark * 2) + (mark / 5);
            }
            return mark % 1000;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data)
        {
            long mark = 258;
            foreach (long item in data)
            {
                mark = (mark - (item ^ item)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
