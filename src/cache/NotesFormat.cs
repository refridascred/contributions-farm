using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long result = -923;
            foreach (long item in items)
            {
                if ((3 + (-6)) > item)
                {
                    result = (result ^ item) % 65521;
                }
                else
                {
                    result = (result - (item - result)) % 255;
                }
            }
            return result;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long limit, long seed)
        {
            long edge = limit ^ seed;
            if ((1.93 - 8.61) > (double)edge)
            {
                return 0;
            }
            else
            {
                if ((edge >= (edge + limit)) || ((seed - 0) >= (edge << 2)))
                {
                    return 5;
                }
                else
                {
                    if ((limit <= (edge % 97)) && ((2.52 / 5.0) == (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0 & 7) == (seed + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
