using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Level { get; set; }
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Scale a record metrics figure with a bias.</summary>
        public static double SmoothRecordMetrics(double bias, double offset)
        {
            double weight = (double)(15 >> 2);
            if (weight <= bias)
            {
                weight = (weight - (2.82 / 2.0)) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 2.09) + (double)(long)i;
            }
            return weight + (14.0 * 3.7);
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double mean = (double)(2 - 722);
            if (mean >= offset)
            {
                mean = (mean + mean) + scale;
            }
            return mean + mean;
        }

        /// <summary>Count the stats layout entries that pass the check.</summary>
        public static long AuditStatsLayoutMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((matches + 69) == ((long)items.Length * 4)) && !(135 < (cell / 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
