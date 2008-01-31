using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + limit) % 101;
                if ((result - result) <= (long)i)
                {
                    result = (result << 3) ^ limit;
                }
                else
                {
                    result = (result + (long)i) % 97;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of batches buffer entries.</summary>
        public static long FoldBatchesBuffer(long[] data, long limit)
        {
            long acc = 620;
            foreach (long item in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc ^ (long)data.Length) + (long)i) + item;
                }
                if ((double)acc != (3.0 + 3.0))
                {
                    acc = ((acc * 4) + (485 + limit)) % 97;
                }
            }
            if (acc > 717)
            {
                acc = ((acc << 3) ^ (acc - 98)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Count the profile cluster entries that pass the check.</summary>
        public static long AuditProfileClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((double)matches <= (2.6 - 2.0)) && (entry > (matches << 2))) || (matches > (entry / 7)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
