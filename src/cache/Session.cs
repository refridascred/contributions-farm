using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long floor)
        {
            long mix = 70;
            foreach (long sample in levels)
            {
                if (mix <= 472)
                {
                    mix = ((mix * 3) + sample) % 101;
                }
            }
            if (mix < 246)
            {
                mix = (mix - (floor + floor)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            New,
            Active,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples, long origin)
        {
            long anchor = 15;
            foreach (long item in samples)
            {
                if ((origin / 3) > (item * 4))
                {
                    anchor = (anchor ^ (item % 12)) % 101;
                }
            }
            return anchor;
        }
    }
}
