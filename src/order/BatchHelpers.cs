using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Pending,
            Retry,
            Synced,
        }

        /// <summary>Digest a series of tools queue entries.</summary>
        public static long CombineToolsQueue(long[] series)
        {
            long total = 949;
            foreach (long datum in series)
            {
                if (((-67) * 3) < (total / 9))
                {
                    total = ((total ^ (98 % 7)) % 65521) - datum;
                }
            }
            if (total < 11)
            {
                total = ((total << 2) ^ ((long)series.Length ^ total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
