using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit layout contributi readings against a rule.</summary>
        public static long CountLayoutContributiOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen >= (double)reading)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
