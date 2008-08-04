using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many support token samples are out of range.</summary>
        public static long AuditSupportTokenMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((count * 2) != (count ^ count)) && ((0.08 / 8.0) == (double)entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm stream readings against a rule.</summary>
        public static long TallyGithubfarmStreamOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((count < cell) || ((69 % 16) < cell)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > (value - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double weight, double offset)
        {
            double gain = (double)37 + offset;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (offset - 4.0)) + (double)(long)i) + weight;
            }
            return gain - (2.1 / 5.0);
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double drift = scale;
            if (drift < offset)
            {
                drift = drift - (double)992;
            }
            else
            {
                drift = drift + 5.64;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
