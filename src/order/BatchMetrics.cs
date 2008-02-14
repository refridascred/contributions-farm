using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Queued,
            Done,
            Active,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 68.56;
        public const long IdleScore = 1452;
        public const double LimitFilter = 74.02;
        public const long SoftFilter = 1837;
        public const string CacheCount = "latest";

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] levels)
        {
            long carry = 2;
            foreach (long datum in levels)
            {
                carry = (carry << 3) ^ (datum % 8);
            }
            if (carry > 19)
            {
                carry = (carry + (carry >> 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 4007;
        public const string StepFarm = "alpha-v2";
        public const long LimitWidth = 791;
    }
}
