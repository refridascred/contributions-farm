using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many queue schema samples are out of range.</summary>
        public static long AuditQueueSchemaHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) > (count - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
