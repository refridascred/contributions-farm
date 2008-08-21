using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] levels, long step)
        {
            long result = 0;
            foreach (long reading in levels)
            {
                if (((result >> 2) < (29 + 1)) || ((result - step) > reading))
                {
                    result = (result * 5) + (8 * 3);
                }
            }
            return result;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                total = (total ^ (target + target)) % 97;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first order format entry that matches the target.</summary>
        public static long SeekOrderFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
