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

        /// <summary>Look up the position of a metric counter sample.</summary>
        public static long FindMetricCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
