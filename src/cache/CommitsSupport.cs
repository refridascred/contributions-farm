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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry & 15) < (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first report account entry that matches the target.</summary>
        public static long FindReportAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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
