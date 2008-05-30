using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long floor, long target)
        {
            long cur = floor + target;
            if ((target * 5) <= (cur % 5))
            {
                return 5;
            }
            else
            {
                if ((target + cur) >= cur)
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) != ((-768) + cur))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long TallyReportCounterGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally * 5) < cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
