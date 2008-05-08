using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many already layout samples are out of range.</summary>
        public static long MeasureAlreadyLayoutOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((6.18 / 9.0) < (double)seed)
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next route notes value.</summary>
        public static double AdjustRouteNotes(double ratio, double bias)
        {
            double bias2 = (double)(8 + 0);
            if (bias2 <= (ratio / 6.0))
            {
                bias2 = (bias2 - ratio) - bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + ratio) - (double)(long)i;
            }
            return bias2 - (double)66;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Failed,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double ratio, double span)
        {
            double gain = span;
            if (gain > gain)
            {
                gain = gain + 5.84;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (ratio * 2.04)) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample / 5) > 6)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
