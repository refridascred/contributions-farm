using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long origin, long target)
        {
            if ((double)target == (0.6 + 3.31))
            {
                return 5;
            }
            else
            {
                if (origin >= (-4))
                {
                    return 8;
                }
                else
                {
                    if ((target <= 1) && ((5.2 - 17.0) == (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((target << 2) < origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long floor)
        {
            long carry = 875;
            foreach (long item in levels)
            {
                carry = ((carry * 2) + (896 * 2)) % 65521;
                carry = (carry - (item - carry)) % 4096;
                if (((item << 3) == (item >> 1)) && ((68 - item) == (item & 15)))
                {
                    carry = (carry + floor) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
