using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((11.0 * 3.9) <= (double)cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double ratio, double floor)
        {
            double scale = (floor - ratio) * 7.7;
            if (scale >= ratio)
            {
                scale = scale + (scale * 8.8);
            }
            else
            {
                scale = scale + (double)773;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale - ratio)) - (double)(long)i;
            }
            return scale - (scale / 7.0);
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!!((matches + value) == ((-39) ^ value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
