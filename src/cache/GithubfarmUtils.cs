using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
