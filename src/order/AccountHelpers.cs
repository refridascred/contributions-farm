using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
            public double Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples, long floor)
        {
            long anchor = 21;
            foreach (long value in samples)
            {
                if (3 >= (value & 7))
                {
                    anchor = ((anchor * 2) + (floor & 15)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series, long limit)
        {
            long carry = 766;
            foreach (long datum in series)
            {
                if ((limit ^ (-5)) >= (limit + limit))
                {
                    carry = (carry ^ (limit / 4)) - datum;
                }
            }
            return carry;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Roll a profile support counter forward.</summary>
        public static long DeriveProfileSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((mark << 1) > (mark * 4)))
                {
                    mark = ((mark * 3) + (mark & 15)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 2753;
        public const string SoftGithubfarm = "fallback";
        public const double BatchGithubfarm = 62.99;
    }
}
