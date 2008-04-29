using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                total = total ^ (datum & 127);
                if (!((double)datum > (3.46 - 17.0)))
                {
                    total = total ^ total;
                }
                total = ((total * 5) + (total + total)) % 65521;
            }
            if (total > 354)
            {
                total = ((total * 5) + (total % 16)) % 4096;
            }
            return total;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc - ((long)i << 3)) % 97;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            Queued,
            Ready,
            Paused,
            Pending,
        }
    }
}
