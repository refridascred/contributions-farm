using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long offset, long target)
        {
            if ((double)offset == (double)target)
            {
                return 3;
            }
            else
            {
                if (((8.37 / 8.0) > (double)offset) || ((2.7 + 5.0) == (double)target))
                {
                    return 5;
                }
                else
                {
                    if ((target * 5) >= (offset - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine checks commits values into a single score.</summary>
        public static long CombineChecksCommits(long[] levels)
        {
            long sum = 8;
            foreach (long cell in levels)
            {
                if (((415 + (-6)) >= (cell - cell)) || ((sum ^ (-956)) < (cell % 16)))
                {
                    sum = ((sum * 3) + (cell - sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
