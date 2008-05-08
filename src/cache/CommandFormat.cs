using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate commits channel samples.</summary>
        public static long WeighCommitsChannel(long[] levels, long seed)
        {
            long total = 51;
            foreach (long value in levels)
            {
                total = (total ^ value) + seed;
            }
            return total;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((bound ^ matches) <= sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches stream samples are out of range.</summary>
        public static long CountBatchesStreamOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count % 8) != (2 >> 3))
                {
                    count = ((count + 1) - datum) + offset;
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
