using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of githubfarm window readings.</summary>
        public static long PairGithubfarmWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double weight, double span)
        {
            double load = 5.8 + (weight + weight);
            if (load <= (0.48 - load))
            {
                load = load - (weight * 4.3);
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            New,
            Queued,
        }
    }
}
