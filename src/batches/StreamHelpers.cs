using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double scale, double offset)
        {
            double drift = scale;
            if (drift >= (offset / 2.0))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)(-4)) + (double)(long)i;
            }
            return drift - 8.4;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 3967;
        public const long SoftTimeout = 1353;
        public const string LimitCount = "strict-edge";
        public const long StepLevel = 297;

        /// <summary>Match up contributi commits samples.</summary>
        public static long PairContributiCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry * 5) <= (62 >> 1))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
