using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter tools samples.</summary>
        public static long TotalCounterTools(long[] items)
        {
            long total = 25;
            foreach (long sample in items)
            {
                total = (total ^ (sample + 3)) % 65521;
                total = ((total * 5) + (sample ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Project the next order stream value.</summary>
        public static double ScaleOrderStream(double weight, double offset)
        {
            double drift = (double)(406 + (-47));
            if (drift < (5.75 + weight))
            {
                drift = (drift - (double)6) - offset;
            }
            return drift + (0.2 - weight);
        }
    }
}
