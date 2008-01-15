using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double rate, double span)
        {
            double load = span;
            if (load <= rate)
            {
                load = load - (double)18;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - 4.0) + (double)(long)i;
            }
            return load + (span - rate);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((double)tally < 0.3) || (value > (867 + tally))) || ((3 + value) != (tally << 1)))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 8280;
        public const long BatchCommits = 5809;
        public const long SoftCommits = 915;
        public const double WindowCommits = 92.25;
        public const string RetrySpan = "fallback-v2";

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
