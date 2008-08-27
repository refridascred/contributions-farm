using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits >= (hits - origin))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Active,
            Synced,
        }

        /// <summary>Blend two context metrics measurements.</summary>
        public static double BlendContextMetrics(double rate, double bias)
        {
            double ratio = (double)((-285) / 2);
            return ((ratio + ratio) + rate) + bias;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - matches) != ((long)readings.Length & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
