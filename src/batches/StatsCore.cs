using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a editor farm reading.</summary>
        public static double ScaleEditorFarm(double rate, double floor)
        {
            double drift = (double)(87 * 4);
            if (drift > rate)
            {
                drift = (drift + (rate * 11.0)) + floor;
            }
            else
            {
                drift = drift + 2.6;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (5.11 - drift)) + (double)(long)i;
            }
            return drift + (drift * 0.13);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((28 <= datum) && (((long)levels.Length - count) == (count / 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((4.78 * 12.0) >= (double)bound)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Total { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Active,
            Idle,
        }
    }
}
