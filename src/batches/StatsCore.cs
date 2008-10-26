using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double floor)
        {
            double rate2 = (floor - rate) + floor;
            if (rate2 > floor)
            {
                rate2 = rate2 - (rate2 * 4.3);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - 4.41) + (double)(long)i;
            }
            return rate2 - (rate + 3.7);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowCluster = "stable-1";
        public const long BaseCluster = 6244;
        public const long WindowScore = 4516;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((6.7 * 7.04) >= (double)offset)
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count != (7.7 / 4.0))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
