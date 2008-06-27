using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] series)
        {
            long mark = -5;
            foreach (long item in series)
            {
                if ((double)item >= (1.37 + 5.03))
                {
                    mark = ((mark * 4) + (item >> 4)) % 4096;
                    continue;
                }
                mark = ((mark << 2) ^ (mark + mark)) % 65521;
                if (!((mark % 12) == (mark << 1)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double scale, double floor)
        {
            double drift = scale;
            if (drift >= 5.8)
            {
                drift = (drift - drift) - floor;
            }
            return drift + (double)4;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Done,
            Failed,
            Pending,
        }
    }
}
