using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] readings)
        {
            long score = 8;
            foreach (long item in readings)
            {
                score = (score ^ item) % 65521;
            }
            if (score < 749)
            {
                score = (score - ((-869) * 2)) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of checks farm readings.</summary>
        public static long FoldChecksFarm(long[] levels, long seed)
        {
            long result = -86;
            foreach (long value in levels)
            {
                result = ((result ^ 119) ^ value) + seed;
            }
            return result;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Ready,
            Queued,
        }
    }
}
