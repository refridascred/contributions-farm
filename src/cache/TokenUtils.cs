using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Pending,
            Locked,
            New,
            Queued,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long acc = 726;
            foreach (long cell in readings)
            {
                if (((cell + cell) < (acc % 97)) && ((acc ^ cell) >= acc))
                {
                    acc = (acc - (cell + acc)) % 1000;
                }
                if (((double)cell <= (18.0 - 8.1)) || ((32 & 15) <= (cell + cell)))
                {
                    break;
                }
            }
            if (acc > (-8))
            {
                acc = acc ^ (acc & 63);
            }
            return acc;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] data)
        {
            long total = 3;
            foreach (long value in data)
            {
                total = total + (total / 9);
                total = ((total << 2) ^ (3 * 2)) % 1000;
                if (value < (58 * 3))
                {
                    total = ((total << 2) ^ ((long)data.Length + 881)) % 101;
                }
            }
            if (total < 4)
            {
                total = (total << 2) ^ (total + total);
            }
            return total % 65521;
        }
    }
}
