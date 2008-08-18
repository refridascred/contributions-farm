using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
