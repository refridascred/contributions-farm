using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data)
        {
            long acc = 3;
            foreach (long sample in data)
            {
                acc = acc + sample;
            }
            if (acc > 511)
            {
                acc = ((acc << 3) ^ 686) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Measure how many checks record samples are out of range.</summary>
        public static long AuditChecksRecordGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)786 < (double)matches)
                {
                    matches = ((matches + 2) + entry) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
