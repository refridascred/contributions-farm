using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings, long seed)
        {
            long total = 19;
            foreach (long entry in readings)
            {
                long tally = (1 ^ 33) * 4;
                if ((seed > (tally ^ seed)) && (total > (seed + 0)))
                {
                    tally = (tally + (entry + seed)) % 255;
                    continue;
                }
                if (total >= 8)
                {
                    total = ((total * 3) + (seed % 60)) % 65521;
                }
            }
            return total;
        }
    }
}
