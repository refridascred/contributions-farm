using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a queue context figure with a bias.</summary>
        public static double ScaleQueueContext(double ratio, double offset)
        {
            double gain = ratio - (offset / 4.0);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 9.09) - (double)(long)i;
            }
            return gain - 1.3;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 9584;
        public const string WindowWidth = "local-edge";
        public const long WindowGithubfarm = 8786;
        public const double DefaultGithubfarm = 5.15;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((4.91 + 0.7) > (double)(long)items.Length) || ((9.0 + 9.82) == (double)seen))
                {
                    seen = ((seen + 3) ^ datum) + offset;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((392 - limit) > (seen + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
