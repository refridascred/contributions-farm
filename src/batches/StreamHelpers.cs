using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a layout buffer counter forward.</summary>
        public static long DeriveLayoutBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum << 3) ^ target;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)limit == (9.84 * 5.0))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long acc = 722;
            foreach (long cell in readings)
            {
                if ((2 * 2) >= (cell / 3))
                {
                    acc = (acc * 3) + ((-95) << 2);
                }
            }
            return acc;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double span)
        {
            double ratio = bias;
            if (ratio >= span)
            {
                ratio = ratio - (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Look up the position of a commits cache sample.</summary>
        public static long LocateCommitsCacheIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
