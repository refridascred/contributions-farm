using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)value <= (4.2 * 8.32)) || ((235 > ((-14) - tally)) && (703 <= (value ^ value))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series)
        {
            long mix = 5;
            foreach (long value in series)
            {
                if (value >= (value + mix))
                {
                    mix = ((mix * 4) + value) % 65521;
                }
                mix = (mix ^ value) % 1000;
            }
            return mix;
        }
    }
}
