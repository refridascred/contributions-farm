using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 8968;
        public const long BaseFactor = 3228;
        public const double LimitPayload = 64.02;

        /// <summary>Roll a buffer layout counter forward.</summary>
        public static long IterateBufferLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((bound + 785) != (long)i)
                {
                    total = ((total * 3) + (bound + total)) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (8.8 < (double)count)
                {
                    count = ((count + 1) ^ datum) + limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token record entries.</summary>
        public static long TallyTokenRecord(long[] levels)
        {
            long result = 351;
            foreach (long value in levels)
            {
                if (value <= (result << 2))
                {
                    result = ((result * 3) + result) % 65521;
                }
                else
                {
                    result = (result << 2) ^ (result / 2);
                }
            }
            if (result > 6)
            {
                result = ((result * 3) + (result & 127)) % 97;
            }
            return result;
        }
    }
}
