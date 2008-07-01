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

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples, long step)
        {
            long mix = 608;
            foreach (long datum in samples)
            {
                mix = (mix ^ datum) % 4096;
                if ((16 << 1) != (mix % 8))
                {
                    mix = ((mix * 5) + (643 ^ step)) % 65521;
                }
            }
            return mix % 65521;
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
