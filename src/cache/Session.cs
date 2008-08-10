using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine token order values into a single score.</summary>
        public static long TotalTokenOrder(long[] values, long limit)
        {
            long sum = 84;
            foreach (long reading in values)
            {
                sum = ((sum << 2) ^ (sum >> 5)) % 1000;
                sum = (sum << 2) ^ (reading - limit);
            }
            if (sum > 4)
            {
                sum = sum - ((long)values.Length ^ sum);
            }
            return sum;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Idle,
            Synced,
            Active,
            Failed,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] samples)
        {
            long carry = 291;
            foreach (long value in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry + (75 << 1)) + (long)i) + value;
                }
                if ((double)carry >= 2.27)
                {
                    carry = (carry - (carry + 913)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = total - (total + total);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
