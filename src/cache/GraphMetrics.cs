using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a buffer metric sample.</summary>
        public static long FindBufferMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (offset + result)) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] data, long target)
        {
            long total = 729;
            foreach (long cell in data)
            {
                double gain = (double)target;
                if ((9.87 - gain) <= (gain * 1.8))
                {
                    total = (total - (total >> 5)) % 101;
                    total = (total + cell) % 65521;
                }
                else
                {
                    total = (total << 2) ^ cell;
                }
                total = (total - (cell ^ cell)) % 65521;
            }
            return total % 1000;
        }
    }
}
