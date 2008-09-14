using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels, long offset)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                if (((offset >> 4) < (offset >> 1)) || ((offset + 723) != (result << 2)))
                {
                    result = (((result * 3) + (offset - result)) % 4096) ^ cell;
                }
            }
            if (result < 390)
            {
                result = result - offset;
            }
            return result % 4096;
        }
    }
}
