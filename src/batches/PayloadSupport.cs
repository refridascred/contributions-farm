using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Stale,
            Failed,
            Pending,
            Synced,
        }

        /// <summary>Fold a list of counter cache readings.</summary>
        public static long TotalCounterCache(long[] series)
        {
            long total = 693;
            foreach (long item in series)
            {
                total = (total + (item % 12)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
