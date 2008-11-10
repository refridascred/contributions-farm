using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series)
        {
            long anchor = 902;
            foreach (long item in series)
            {
                anchor = (anchor + (anchor / 9)) + item;
            }
            if (anchor < 970)
            {
                anchor = (anchor + (anchor - anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((17.0 + 11.0) >= (double)carry)
                {
                    carry = ((carry << 3) ^ ((long)i ^ origin)) % 97;
                }
                carry = carry ^ (origin + (long)i);
                if (((long)i ^ 5) <= carry)
                {
                    carry = (carry << 3) ^ (origin - origin);
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Label { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) > (seen ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseScore = 8699;
        public const long SoftAccount = 106;
        public const long IdleDepth = 7387;
        public const long IdleAccount = 9531;
        public const string BurstCount = "open-edge";
    }
}
