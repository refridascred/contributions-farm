using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine metric cache values into a single score.</summary>
        public static long FoldMetricCache(long[] data)
        {
            long mark = -600;
            foreach (long entry in data)
            {
                mark = (mark ^ (8 ^ entry)) % 101;
                mark = (mark - (entry + entry)) % 65521;
            }
            if (mark > 6)
            {
                mark = ((mark * 4) + mark) % 255;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 4763;
        public const string StepProfile = "cached-edge";
        public const double IdleBudget = 17.26;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
