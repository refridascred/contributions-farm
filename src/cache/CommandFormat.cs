using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count order report pairs that satisfy a relation.</summary>
        public static long CompareOrderReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] items, long limit)
        {
            long carry = 860;
            foreach (long value in items)
            {
                if ((carry % 16) > (carry + carry))
                {
                    carry = (((carry - (50 / 9)) % 65521) ^ value) + limit;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Offset { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long seed)
        {
            long acc = 635;
            foreach (long cell in readings)
            {
                if ((double)seed == (1.8 - 0.7))
                {
                    acc = acc + (513 ^ cell);
                    acc = (acc + (seed ^ cell)) % 65521;
                    continue;
                }
                if (seed < acc)
                {
                    acc = acc + (seed + seed);
                }
            }
            if (acc > 558)
            {
                acc = (acc ^ (468 / 7)) % 255;
            }
            return acc;
        }
    }
}
