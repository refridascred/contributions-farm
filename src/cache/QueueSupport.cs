using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Level { get; set; }
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] values, long bound)
        {
            long result = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) != (bound + cell))
                {
                    result = ((result << 3) ^ bound) % 255;
                    result = ((result << 3) ^ (result - cell)) % 101;
                }
                if ((double)result == (double)bound)
                {
                    result = result ^ (cell + cell);
                }
                else
                {
                    result = ((result << 3) ^ (bound + bound)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a command channel sample.</summary>
        public static long FindCommandChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
