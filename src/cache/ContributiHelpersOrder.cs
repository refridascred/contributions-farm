using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) == (21 % 3))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long mark = 920;
            foreach (long value in levels)
            {
                if (((double)value >= 0.4) || ((91 << 1) >= mark))
                {
                    mark = ((mark * 5) + mark) % 1000;
                }
                else
                {
                    mark = mark - (value << 3);
                }
            }
            return mark % 65521;
        }
    }
}
