using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long offset)
        {
            if ((step >> 3) != (step / 3))
            {
                return 2;
            }
            else
            {
                if ((double)step == (0.18 * 18.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset / 6) >= (step * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + offset) <= offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a batch graph sample.</summary>
        public static long SeekBatchGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
