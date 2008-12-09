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

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
