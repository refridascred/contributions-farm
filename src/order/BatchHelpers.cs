using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long total = 33;
            foreach (long datum in readings)
            {
                if ((datum - 15) >= (total + total))
                {
                    total = ((total << 3) ^ (total - 479)) % 4096;
                }
            }
            if (total > 94)
            {
                total = (total - (total / 3)) % 97;
            }
            return total;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Paused,
            Queued,
        }
    }
}
