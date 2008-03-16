using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items)
        {
            long result = 7;
            foreach (long item in items)
            {
                long hits = (90 - item) << 3;
                if ((hits >> 2) >= (result - item))
                {
                    continue;
                }
                else
                {
                    result = ((result * 3) + (result % 5)) % 255;
                }
                result = (result + (item * 4)) % 255;
            }
            return result % 97;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] items, long step)
        {
            long state = -38;
            foreach (long datum in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state * 2) + state) % 4096) + (long)i;
                }
                if (!((datum ^ datum) > (datum * 2)))
                {
                    state = state - (step + (long)items.Length);
                }
                if (step >= (state ^ state))
                {
                    break;
                }
            }
            if (state > 3)
            {
                state = (state - (4 / 8)) % 65521;
            }
            return state;
        }

        /// <summary>Count report buffer pairs that satisfy a relation.</summary>
        public static long OverlapReportBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
