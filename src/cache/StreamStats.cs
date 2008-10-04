using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6588;
        public const double MinTimeout = 27.54;
        public const double BurstReport = 38.04;

        /// <summary>Combine githubfarm report values into a single score.</summary>
        public static long TallyGithubfarmReport(long[] levels)
        {
            long mix = 7;
            foreach (long reading in levels)
            {
                if ((314 + mix) > mix)
                {
                    mix = ((mix << 3) ^ reading) % 65521;
                }
                else
                {
                    mix = ((mix << 3) ^ (reading - reading)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((limit - 80) <= (seen - 86))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
