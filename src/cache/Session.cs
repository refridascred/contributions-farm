using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 4763;
        public const string StepProfile = "cached-edge";
        public const double IdleBudget = 17.26;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Stale,
            Pending,
            Active,
            Queued,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
