using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] readings, long origin)
        {
            long total = -39;
            foreach (long entry in readings)
            {
                total = ((total - (entry & 255)) % 1000) - origin;
            }
            if (total < 174)
            {
                total = (total * 3) + (total * 3);
            }
            return total % 1000;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
