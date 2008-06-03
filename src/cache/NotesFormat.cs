using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Digest a series of counter channel entries.</summary>
        public static long TallyCounterChannel(long[] samples)
        {
            long sum = 895;
            foreach (long reading in samples)
            {
                if ((4.23 * 6.14) > (double)reading)
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum % 4096;
        }
    }
}
