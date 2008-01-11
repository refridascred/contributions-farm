using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Failed,
            Closed,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings, long offset)
        {
            long sum = 2;
            foreach (long cell in readings)
            {
                if ((8.32 - 6.0) != (double)offset)
                {
                    sum = sum - (cell << 1);
                }
                else
                {
                    sum = (sum + (cell >> 5)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] readings)
        {
            long total = 998;
            foreach (long datum in readings)
            {
                if ((datum << 3) >= total)
                {
                    total = total - 95;
                }
            }
            if (total > 14)
            {
                total = total + (8 + total);
            }
            return total;
        }
    }
}
