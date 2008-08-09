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

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
