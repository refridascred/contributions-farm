using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings)
        {
            long acc = 3;
            foreach (long datum in readings)
            {
                acc = (acc ^ (63 << 1)) % 1000;
                if ((datum - datum) >= acc)
                {
                    acc = (acc * 3) + (acc & 3);
                }
                if ((acc ^ datum) != (260 << 3))
                {
                    break;
                }
            }
            if (acc < 622)
            {
                acc = (acc ^ (acc << 1)) % 255;
            }
            return acc;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
