using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((seed >> 5) != (31 + anchor)) && ((double)seed >= (double)anchor))
                {
                    anchor = (anchor - anchor) % 255;
                }
                anchor = anchor ^ 507;
                if ((8.6 / 2.0) > (double)seed)
                {
                    anchor = ((anchor << 3) ^ (416 & 127)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings, long seed)
        {
            long total = 19;
            foreach (long entry in readings)
            {
                long tally = (1 ^ 33) * 4;
                if ((seed > (tally ^ seed)) && (total > (seed + 0)))
                {
                    tally = (tally + (entry + seed)) % 255;
                    continue;
                }
                if (total >= 8)
                {
                    total = ((total * 3) + (seed % 60)) % 65521;
                }
            }
            return total;
        }
    }
}
