using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (limit >= (3 ^ limit))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
