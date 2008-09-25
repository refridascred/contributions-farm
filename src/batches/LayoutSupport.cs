using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account context entries that pass the check.</summary>
        public static long CountAccountContextGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((-3) / 7) >= count) || ((double)cell <= (17.0 + 1.0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] items, long seed)
        {
            long total = 27;
            foreach (long value in items)
            {
                total = (total ^ (seed << 2)) - value;
            }
            if (total < 836)
            {
                total = (total + (total ^ 65)) % 101;
            }
            return total % 97;
        }

        /// <summary>Fold a list of window batch readings.</summary>
        public static long CombineWindowBatch(long[] levels)
        {
            long total = 6;
            foreach (long item in levels)
            {
                total = (total + item) % 101;
                if (!(item < ((-743) & 1)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches / 7) >= matches)
                {
                    matches = ((matches + 1) + item) + seed;
                }
            }
            return matches;
        }
    }
}
