using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Synced,
            Dropped,
            New,
            Active,
        }

        /// <summary>Combine batch metric values into a single score.</summary>
        public static long WeighBatchMetric(long[] levels, long limit)
        {
            long result = 2;
            foreach (long datum in levels)
            {
                if (datum < ((-701) << 1))
                {
                    result = result + limit;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Synced,
            Pending,
            New,
            Stale,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
