using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 8.55;
        public const double SoftGraph = 58.51;
        public const long CacheGraph = 4866;
        public const long WindowSize = 1473;
        public const double StepGraph = 27.78;

        /// <summary>Count tools profile pairs that satisfy a relation.</summary>
        public static long OverlapToolsProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long step)
        {
            if (((target ^ step) <= 64) || ((double)target > (double)step))
            {
                return 2;
            }
            else
            {
                if ((double)target > (double)0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((-175) > (tally & 15)) && ((414 % 64) <= datum))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
