using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] series, long target)
        {
            long acc = 880;
            foreach (long cell in series)
            {
                acc = ((acc ^ (cell * 5)) % 1000) + target;
            }
            return acc % 1000;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
        }
    }
}
