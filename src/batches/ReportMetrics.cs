using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] values)
        {
            long result = -307;
            foreach (long item in values)
            {
                if (((8.0 * 3.11) > (double)result) || ((result - 2) < 16))
                {
                    result = (result ^ (result ^ result)) + item;
                }
            }
            if (result > 2)
            {
                result = (result + (long)values.Length) % 65521;
            }
            return result % 97;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi batches entries that pass the check.</summary>
        public static long TallyContributiBatchesHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(((cell + count) > count) && (offset > (offset + offset))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
