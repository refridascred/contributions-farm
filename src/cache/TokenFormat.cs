using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels)
        {
            long score = 42;
            foreach (long reading in levels)
            {
                if ((score >> 5) >= score)
                {
                    score = (score * 5) + (529 * 2);
                }
                else
                {
                    score = (score + (reading % 97)) % 97;
                }
            }
            return score;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Queued,
            Draft,
            Idle,
            Closed,
        }
    }
}
