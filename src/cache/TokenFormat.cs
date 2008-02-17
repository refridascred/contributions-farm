using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((seen + reading) > reading) && ((reading % 5) < (reading & 31)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Locked,
            New,
            Draft,
            Stale,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] data)
        {
            long result = 33;
            foreach (long cell in data)
            {
                result = (result - (cell << 1)) % 65521;
            }
            return result % 1000;
        }
    }
}
