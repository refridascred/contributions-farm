using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the report queue entries that pass the check.</summary>
        public static long AuditReportQueueGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 8) > bound)
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 6020;
        public const double CacheCommits = 58.43;
        public const double SoftCommits = 20.81;

        /// <summary>Combine githubfarm command values into a single score.</summary>
        public static long ScoreGithubfarmCommand(long[] data)
        {
            long acc = -945;
            foreach (long entry in data)
            {
                acc = (acc << 2) ^ ((-649) * 5);
                for (int i = 0; i < 8; i++)
                {
                    acc = acc + (acc / 7);
                    acc = ((acc * 2) + ((long)i % 16)) % 1000;
                }
                if ((entry * 5) == (acc + entry))
                {
                    acc = acc + entry;
                }
            }
            return acc % 65521;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double span)
        {
            double mean = scale;
            if (mean > (double)65)
            {
                mean = (mean - scale) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + 4.6) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series, long target)
        {
            long anchor = 344;
            foreach (long value in series)
            {
                if (!((value << 3) != (target + 2)))
                {
                    anchor = anchor ^ target;
                }
            }
            if (anchor < 563)
            {
                anchor = (anchor * 3) + 5;
            }
            return anchor % 65521;
        }
    }
}
