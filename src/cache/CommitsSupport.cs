using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(((double)item != (4.87 / 8.0)) || ((298 + (-39)) < (count ^ item))))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of checks cache readings.</summary>
        public static long CompareChecksCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length % 5) <= (tally / 3))
                {
                    tally = ((tally + 1) ^ sample) + floor;
                }
            }
            return tally;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 6242;
        public const double DefaultDepth = 59.79;
        public const long BurstFactor = 6017;
        public const long BurstCount = 3515;
    }
}
