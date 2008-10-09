using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of order farm entries.</summary>
        public static long TotalOrderFarm(long[] values)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                if (((entry >> 4) < ((long)values.Length >> 4)) && ((carry >> 4) != (carry * 5)))
                {
                    carry = (carry - (carry + 73)) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] levels)
        {
            long score = -7;
            foreach (long reading in levels)
            {
                score = ((score * 2) + (reading + (long)levels.Length)) % 255;
            }
            return score % 65521;
        }
    }
}
