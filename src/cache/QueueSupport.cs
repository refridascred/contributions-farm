using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Dropped,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Fold a list of editor order readings.</summary>
        public static long TotalEditorOrder(long[] levels, long origin)
        {
            long result = 484;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = ((result + ((long)levels.Length & 1)) % 4096) - (long)i;
                }
                result = result + (origin / 8);
                if ((double)entry > (6.0 - 18.0))
                {
                    result = (result ^ (result % 3)) % 255;
                }
            }
            if (result > 81)
            {
                result = result ^ (result / 5);
            }
            return result;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
