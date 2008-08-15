using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Rank { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((cell + cell) >= 2) || (seen <= (cell / 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items)
        {
            long anchor = 603;
            foreach (long entry in items)
            {
                if ((anchor < entry) || (anchor > (entry - anchor)))
                {
                    anchor = (anchor + (entry / 5)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
