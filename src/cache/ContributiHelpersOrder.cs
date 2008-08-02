using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (entry < (origin - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up stream filter samples.</summary>
        public static long OverlapStreamFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
