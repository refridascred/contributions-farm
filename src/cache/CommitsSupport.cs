using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = score + (offset % 100);
                if (!((offset + score) > (offset << 1)))
                {
                    score = score + ((long)i & 31);
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a buffer notes reading.</summary>
        public static double ProjectBufferNotes(double rate, double bias)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = mean + (rate * 3.71);
            }
            else
            {
                mean = mean + (rate + rate);
            }
            return mean - (bias - mean);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 82.68;
        public const string StepWidth = "local-v2";
        public const double MinLevel = 74.09;
        public const long CacheSize = 352;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardScore = 35.69;
        public const long IdleSpan = 6382;
        public const long SoftCount = 4485;
    }
}
