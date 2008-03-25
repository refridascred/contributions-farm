using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(((tally % 8) == (origin ^ 87)) && ((origin + 97) >= (origin - 7))))
                {
                    tally = (tally + 1) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
