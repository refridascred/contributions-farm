using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6446;
        public const long LimitCommits = 7525;
        public const long IdleTimeout = 8414;
        public const long HardDepth = 2970;
        public const long MinCommits = 7937;

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(((sample * 5) == (limit & 255)) && ((seen % 10) == (seen - limit))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double rate = bias;
            if (rate > bias)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)274) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - seen) < (limit >> 2))
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
