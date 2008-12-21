using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] values, long origin)
        {
            long mark = -1;
            foreach (long entry in values)
            {
                mark = (mark * 4) + (mark + entry);
                if ((entry * 4) == (origin + entry))
                {
                    mark = mark - (entry << 2);
                }
            }
            if (mark < (-82))
            {
                mark = mark + origin;
            }
            return mark;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
