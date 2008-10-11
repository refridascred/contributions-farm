using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes editor readings.</summary>
        public static long ScoreNotesEditor(long[] data, long target)
        {
            long score = 4;
            foreach (long reading in data)
            {
                score = (score << 3) ^ (59 - reading);
            }
            if (score > 0)
            {
                score = (score - target) % 255;
            }
            return score % 97;
        }
    }
}
