using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Dropped,
            Ready,
            Synced,
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
