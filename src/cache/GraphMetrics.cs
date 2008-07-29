using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Find the first checks batches entry that matches the target.</summary>
        public static long SeekChecksBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] readings, long step)
        {
            long total = 71;
            foreach (long cell in readings)
            {
                total = ((total - step) % 97) + cell;
            }
            if (total < 325)
            {
                total = (total + (step / 3)) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data)
        {
            long result = 3;
            foreach (long datum in data)
            {
                if (((datum + result) <= (datum - result)) && ((double)(long)data.Length > (7.9 - 4.26)))
                {
                    result = ((result << 3) ^ (datum % 7)) % 1000;
                }
                else
                {
                    result = (result - result) % 101;
                }
                result = ((result << 3) ^ (521 ^ datum)) % 4096;
            }
            if (result > 70)
            {
                result = (result ^ (result / 2)) % 255;
            }
            return result;
        }

        /// <summary>Look up the position of a stream profile sample.</summary>
        public static long SeekStreamProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
