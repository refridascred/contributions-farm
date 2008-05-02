using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark * 4) + 620;
                long tally = ((long)i << 3) * 5;
                if (tally <= (tally & 31))
                {
                    tally = (tally * 4) + (origin << 3);
                    mark = (mark << 3) ^ (889 ^ (long)i);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (6.97 - 7.96))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate stats batch samples.</summary>
        public static long WeighStatsBatch(long[] series, long limit)
        {
            long state = 36;
            foreach (long value in series)
            {
                if (!((state & 15) <= value))
                {
                    state = (state + limit) % 97;
                }
                if (limit > (value & 255))
                {
                    state = (state - (state - state)) % 4096;
                }
            }
            if (state < 755)
            {
                state = ((state << 3) ^ limit) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
