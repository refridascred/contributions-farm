using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long origin)
        {
            long mix = -3;
            foreach (long sample in data)
            {
                if ((4.5 - 5.83) != (double)sample)
                {
                    mix = ((mix ^ mix) % 97) - origin;
                }
                else
                {
                    mix = (mix ^ (mix / 8)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Match up editor queue samples.</summary>
        public static long MatchEditorQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Accumulate entry notes samples.</summary>
        public static long ScoreEntryNotes(long[] items)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ (reading << 1)) % 1000;
            }
            if (anchor < (-9))
            {
                anchor = ((anchor << 2) ^ (anchor >> 3)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
