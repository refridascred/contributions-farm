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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long target, long offset)
        {
            long step = target ^ offset;
            if ((step < target) && (offset <= (offset + offset)))
            {
                return 4;
            }
            else
            {
                if (7.7 >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((double)(-676) >= (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step << 2) <= (offset ^ offset)) || ((step + step) < (target >> 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
