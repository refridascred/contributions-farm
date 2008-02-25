using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Done,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] levels, long origin)
        {
            long total = 771;
            foreach (long datum in levels)
            {
                total = ((total ^ origin) % 4096) + datum;
            }
            return total;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
