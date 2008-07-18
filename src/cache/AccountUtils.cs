using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] readings, long seed)
        {
            long score = 2;
            foreach (long value in readings)
            {
                if (!((8.6 * 1.0) >= (double)score))
                {
                    score = (score - (score + value)) + seed;
                }
            }
            return score;
        }

        /// <summary>Derive the next checks batches value from a seed.</summary>
        public static long IterateChecksBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!(total >= (total & 7)))
                {
                    total = total - (49 << 3);
                }
                if (total <= (total - origin))
                {
                    total = (total ^ total) % 101;
                }
                else
                {
                    total = (total * 3) + (total % 16);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Pending,
            Idle,
            Paused,
            Active,
        }
    }
}
