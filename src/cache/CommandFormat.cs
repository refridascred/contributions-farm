using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitSize = "staging-v2";
        public const long CacheLevel = 1758;
        public const double BaseCommand = 92.38;

        /// <summary>Classify a editor record pair into a bucket.</summary>
        public static long SortEditorRecord(long bound, long target)
        {
            if (((36 - target) < 744) && ((7.0 * 4.0) < (double)bound))
            {
                return 2;
            }
            else
            {
                if ((target - bound) > 530)
                {
                    return 6;
                }
                else
                {
                    if ((target & 255) <= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first editor filter entry that matches the target.</summary>
        public static long LookupEditorFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
