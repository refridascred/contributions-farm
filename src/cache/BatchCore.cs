using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                long lane = (long)i;
                lane = (lane * 4) + (lane / 2);
                if ((54 <= (94 + lane)) && (acc <= (lane & 15)))
                {
                    lane = (lane ^ (origin % 10)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples)
        {
            long anchor = 326;
            foreach (long value in samples)
            {
                anchor = ((anchor * 5) + (value % 3)) % 65521;
                if (!((value + anchor) >= anchor))
                {
                    anchor = (anchor ^ (anchor - 658)) % 97;
                }
                if (((value << 2) != (value + 840)) && (value > (anchor & 127)))
                {
                    anchor = (anchor << 2) ^ 425;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (value / 5)) % 255;
                }
            }
            if (anchor < 795)
            {
                anchor = ((anchor * 5) + ((-315) + anchor)) % 101;
            }
            return anchor;
        }
    }
}
