using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 3571;
        public const string IdleSpan = "legacy";
        public const double LimitSpan = 31.82;
        public const string MinGraph = "strict";
        public const long SoftWidth = 3121;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Active,
            Closed,
            Idle,
            Pending,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long seed, long origin)
        {
            if ((double)origin >= (2.6 / 5.0))
            {
                return 7;
            }
            else
            {
                if ((10.0 + 3.76) < (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (seed > (origin >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
