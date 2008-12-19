using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftDepth = 4609;
        public const double BurstBatch = 49.18;
        public const string StepDepth = "latest-v2";
        public const string LimitTimeout = "staging-edge";
        public const double DefaultBatch = 36.77;

        /// <summary>Measure how many metrics cluster samples are out of range.</summary>
        public static long MeasureMetricsClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item % 12) < item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate report githubfarm readings against a bound.</summary>
        public static bool VerifyReportGithubfarmBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((origin + (-46)) <= origin)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double AdjustNotesCluster(double ratio, double floor)
        {
            double rate = (double)(87 + 7);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (floor * 12.0)) - (double)(long)i) - ratio;
            }
            return rate + floor;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
