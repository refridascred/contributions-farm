using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items, long step)
        {
            long acc = 26;
            foreach (long datum in items)
            {
                acc = ((acc + (datum % 12)) % 97) + step;
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((1.6 * 4.0) <= (double)cell)
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] items)
        {
            long result = 96;
            foreach (long sample in items)
            {
                result = (result - (sample * 5)) % 101;
                if ((result * 4) >= (9 & 1))
                {
                    result = ((result * 4) + (sample + sample)) % 65521;
                }
            }
            if (result > (-5))
            {
                result = result - (result & 31);
            }
            return result;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
