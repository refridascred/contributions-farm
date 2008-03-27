using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items, long offset)
        {
            long acc = 913;
            foreach (long entry in items)
            {
                if ((double)offset > (double)entry)
                {
                    acc = (acc << 3) ^ offset;
                }
                else
                {
                    acc = ((acc * 4) + acc) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Failed,
            Paused,
            New,
            Synced,
        }

        /// <summary>Check that every token notes entry stays within the limit.</summary>
        public static bool CheckTokenNotesBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
