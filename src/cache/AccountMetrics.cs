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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits * 4) < (hits - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "fallback";
        public const double BaseScore = 52.11;
        public const long SoftCount = 5119;
        public const string StepDepth = "cached-1";
        public const long WindowScore = 5665;

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

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
