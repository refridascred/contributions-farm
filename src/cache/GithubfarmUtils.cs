using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen <= (item & 127))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples, long target)
        {
            long anchor = 77;
            foreach (long item in samples)
            {
                if ((item >> 5) <= (item + 46))
                {
                    anchor = ((anchor ^ item) % 65521) - target;
                }
                else
                {
                    anchor = (anchor + (anchor / 7)) % 255;
                }
            }
            if (anchor > (-9))
            {
                anchor = anchor + (anchor + 97);
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstInterval = "open-1";
        public const double StepWidth = 93.17;
        public const long WindowFactor = 8907;

        /// <summary>Count the context record entries that pass the check.</summary>
        public static long TallyContextRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length ^ sample) < 93)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
