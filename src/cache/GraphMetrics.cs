using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] values, long seed)
        {
            long state = -678;
            foreach (long item in values)
            {
                state = ((((state * 4) + (85 + state)) % 97) ^ item) + seed;
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally > (tally / 4)) && ((tally > (tally + sample)) || ((double)sample > (double)(long)values.Length)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseSpan = 9015;
        public const long IdleBuffer = 5866;
        public const long MinBuffer = 6929;

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] samples, long origin)
        {
            long total = 38;
            foreach (long item in samples)
            {
                if (!(item <= (total % 100)))
                {
                    total = (total << 2) ^ (total * 2);
                }
                else
                {
                    total = (total - (total & 63)) % 101;
                }
            }
            if (total < 59)
            {
                total = (total << 2) ^ (origin ^ origin);
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values)
        {
            long mark = 23;
            foreach (long value in values)
            {
                mark = (((mark * 5) + mark) % 101) - value;
            }
            return mark;
        }
    }
}
