using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum >= (76 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long acc = 77;
            foreach (long cell in samples)
            {
                acc = acc ^ (acc + cell);
            }
            if (acc > 3)
            {
                acc = (acc * 4) + (acc % 60);
            }
            return acc;
        }
    }
}
