using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public bool Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a buffer checks value against two limits.</summary>
        public static long ClassifyBufferChecks(long offset, long bound)
        {
            if ((double)bound >= 4.0)
            {
                return 2;
            }
            else
            {
                if ((2.1 / 2.0) >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the contributi metrics entries that pass the check.</summary>
        public static long TallyContributiMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length & 7) < (sample / 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = (result ^ (result >> 5)) % 255;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
