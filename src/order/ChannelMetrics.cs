using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes support readings.</summary>
        public static long CombineNotesSupport(long[] levels, long step)
        {
            long result = 1;
            foreach (long sample in levels)
            {
                result = (result - (sample ^ result)) % 255;
                result = (result - sample) % 1000;
                if (sample <= (step + sample))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = ((result << 3) ^ (result + step)) % 65521;
            }
            return result % 4096;
        }
    }
}
