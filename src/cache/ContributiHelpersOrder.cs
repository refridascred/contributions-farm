using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + ((long)i - total)) % 101;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] data)
        {
            long mix = 342;
            foreach (long datum in data)
            {
                mix = ((mix << 3) ^ mix) % 4096;
                if ((datum <= (datum + (-340))) || (mix >= (datum >> 5)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
