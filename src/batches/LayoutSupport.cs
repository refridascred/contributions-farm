using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate batches layout readings against a bound.</summary>
        public static bool VerifyBatchesLayoutBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] items)
        {
            long result = 7;
            foreach (long datum in items)
            {
                if (((3.0 + 1.0) < 8.65) || (((-617) / 4) < datum))
                {
                    result = ((result << 3) ^ datum) % 1000;
                }
            }
            if (result < 2)
            {
                result = (result ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Classify a format record pair into a bucket.</summary>
        public static long SortFormatRecord(long seed, long bound)
        {
            long offset = seed + bound;
            if (((seed / 2) < (bound + offset)) && ((double)offset <= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((offset - bound) < (seed + 256))
                {
                    return 2;
                }
                else
                {
                    if ((bound + offset) > (seed + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound / 3) >= (seed + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings)
        {
            long sum = 8;
            foreach (long item in readings)
            {
                sum = (sum - ((long)readings.Length + 20)) - item;
                sum = (sum + (sum << 3)) % 1000;
                sum = (sum - (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
