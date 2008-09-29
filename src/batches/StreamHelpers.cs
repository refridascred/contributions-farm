using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstFactor = 6;
        public const long LimitGithubfarm = 9767;
        public const string BaseGithubfarm = "primary-edge";
        public const long MaxGithubfarm = 7540;

        /// <summary>Count the metric session entries that pass the check.</summary>
        public static long AuditMetricSessionMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value < (4.1 + 5.7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                if (3 < offset)
                {
                    mark = (mark << 3) ^ (mark - mark);
                    mark = (mark - (mark + offset)) % 1000;
                }
                mark = mark ^ (mark & 63);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                if ((76 & 7) == (acc & 31))
                {
                    acc = (acc ^ (long)readings.Length) % 255;
                }
                if ((acc + cell) > (0 << 3))
                {
                    acc = (acc - cell) % 1000;
                }
                else
                {
                    acc = (acc - 8) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two batch queue measurements.</summary>
        public static double BlendBatchQueue(double weight, double offset)
        {
            double mean = (double)(329 >> 5);
            if (mean >= 13.0)
            {
                mean = mean + (double)330;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean - weight)) - (double)(long)i;
            }
            return mean - (offset + offset);
        }
    }
}
