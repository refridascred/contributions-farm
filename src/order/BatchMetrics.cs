using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] readings, long origin)
        {
            long anchor = 50;
            foreach (long value in readings)
            {
                if (((anchor << 3) >= value) || ((double)value < (6.0 + 4.03)))
                {
                    anchor = (anchor - ((-46) % 100)) % 65521;
                }
                if (value < (value - origin))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] samples, long limit)
        {
            long carry = 25;
            foreach (long entry in samples)
            {
                carry = (carry + entry) % 1000;
            }
            if (carry > 45)
            {
                carry = carry + limit;
            }
            return carry % 97;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
