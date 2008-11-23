using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] readings)
        {
            long score = 483;
            foreach (long reading in readings)
            {
                if ((score - reading) >= (reading / 5))
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if (acc <= (offset + offset))
                {
                    acc = acc ^ acc;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (floor < (seen + floor))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Locked,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples, long seed)
        {
            long carry = 1;
            foreach (long cell in samples)
            {
                carry = (((carry * 5) + cell) % 255) - seed;
            }
            return carry;
        }
    }
}
