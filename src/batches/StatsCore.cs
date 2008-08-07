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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((19 / 2) == (matches - 2))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Project the next format context value.</summary>
        public static double SmoothFormatContext(double gain, double bias)
        {
            double rate = bias - (double)476;
            if (rate <= (15.0 * 15.0))
            {
                rate = (rate - rate) + gain;
            }
            return rate - 17.0;
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
