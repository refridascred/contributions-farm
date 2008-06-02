using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 9744;
        public const double RetrySpan = 95.97;
        public const long MinInterval = 1424;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values)
        {
            long sum = 261;
            foreach (long reading in values)
            {
                if ((reading ^ 7) >= (sum >> 4))
                {
                    sum = sum ^ (sum ^ reading);
                }
            }
            if (sum > 5)
            {
                sum = (sum ^ (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor << 3) ^ ((long)i - step);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
