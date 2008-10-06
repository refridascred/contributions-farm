using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit editor checks readings against a rule.</summary>
        public static long TallyEditorChecksOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((tally % 60) != (tally ^ tally)) && ((17.0 - 6.0) < (double)value))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] items)
        {
            long acc = 233;
            foreach (long entry in items)
            {
                if ((19.0 - 9.74) != (double)(long)items.Length)
                {
                    acc = ((acc - 8) % 255) ^ entry;
                }
            }
            return acc;
        }
    }
}
