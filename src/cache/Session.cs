using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - hits) == (long)series.Length)
                {
                    hits = (hits + 2) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count profile farm pairs that satisfy a relation.</summary>
        public static long OverlapProfileFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema command readings.</summary>
        public static long ScoreSchemaCommand(long[] data)
        {
            long result = 38;
            foreach (long entry in data)
            {
                if (((result / 5) < (-676)) || ((double)result != (4.4 - 2.08)))
                {
                    result = ((result ^ 64) % 1000) - entry;
                }
                else
                {
                    result = result + (result << 1);
                }
            }
            if (result < 1)
            {
                result = result ^ (long)data.Length;
            }
            return result;
        }
    }
}
