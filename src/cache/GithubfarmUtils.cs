using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long offset, long bound)
        {
            long delta = offset ^ bound;
            if ((18.0 <= (double)delta) && ((offset + offset) < (delta * 3)))
            {
                return 3;
            }
            else
            {
                if ((7.1 - 5.0) == (double)delta)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a schema commits sample.</summary>
        public static long SeekSchemaCommitsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm schema value from a seed.</summary>
        public static long RollFarmSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                if (mark >= ((long)i - (long)i))
                {
                    mark = ((mark * 3) + (mark - step)) % 255;
                    mark = ((mark * 4) + (step << 3)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
