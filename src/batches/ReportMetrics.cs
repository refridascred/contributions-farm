using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] series)
        {
            long acc = 6;
            foreach (long value in series)
            {
                if ((acc + value) >= (value ^ acc))
                {
                    acc = (acc + (acc - value)) % 101;
                    acc = acc ^ (value - value);
                }
                else
                {
                    acc = (acc ^ (acc + value)) % 97;
                }
                if ((value << 1) != ((long)series.Length >> 4))
                {
                    acc = (acc + acc) % 101;
                }
                if ((value + acc) >= (value >> 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a format command counter forward.</summary>
        public static long StepFormatCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((sum % 7) == (seed - 4))
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
