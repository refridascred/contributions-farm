using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((double)(long)samples.Length < 1.16))
                {
                    seen = ((seen + 1) + sample) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the profile route entries that pass the check.</summary>
        public static long TallyProfileRouteHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally / 9) != (84 + offset))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache commits samples are out of range.</summary>
        public static long AuditCacheCommitsOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!!((seen ^ entry) != (entry - seen)))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two cluster contributi measurements.</summary>
        public static double ScaleClusterContributi(double scale, double floor)
        {
            double mean = floor;
            if (mean > (mean + scale))
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + 2.46) + (double)(long)i;
            }
            return mean - (floor - mean);
        }
    }
}
