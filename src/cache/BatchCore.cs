using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double gain, double floor)
        {
            double weight = (double)(4 - 573);
            if (weight <= gain)
            {
                weight = weight + floor;
            }
            return weight + (gain * 6.1);
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry + seen) <= step)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
