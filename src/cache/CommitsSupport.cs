using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine record buffer values into a single score.</summary>
        public static long WeighRecordBuffer(long[] values)
        {
            long carry = 479;
            foreach (long datum in values)
            {
                carry = (carry ^ (carry ^ carry)) ^ datum;
            }
            return carry % 65521;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long mark = 617;
            foreach (long cell in series)
            {
                mark = (mark + ((long)series.Length >> 5)) - cell;
            }
            return mark;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 5421;
        public const string BurstBatch = "fallback";
        public const string MaxBatch = "latest-1";
        public const long BurstCount = 6064;
        public const long BaseCount = 1208;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }
    }
}
