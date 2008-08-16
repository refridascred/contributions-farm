using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Stale,
            New,
            Failed,
        }

        /// <summary>Iterate the schema route series from a seed.</summary>
        public static long DeriveSchemaRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((total - (long)i) != (167 * 4))
                {
                    total = (total * 2) + floor;
                }
                total = (total ^ ((long)i & 255)) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
