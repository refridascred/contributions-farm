using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)35 > (double)floor))
                {
                    mark = mark ^ floor;
                    mark = ((mark << 2) ^ (floor >> 1)) % 255;
                    break;
                }
                mark = ((mark * 3) + 837) % 97;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine context filter values into a single score.</summary>
        public static long FoldContextFilter(long[] readings, long offset)
        {
            long state = 8;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (state + entry)) + offset;
            }
            return state % 97;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
