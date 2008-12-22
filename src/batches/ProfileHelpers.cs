using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 68.65;
        public const string WindowNotes = "alpha-1";
        public const double MinRatio = 28.6;
        public const double MinSize = 91.25;

        /// <summary>Look up the position of a profile farm sample.</summary>
        public static long LocateProfileFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Pending,
            New,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long target, long seed)
        {
            if ((double)target > (1.4 - 9.4))
            {
                return 0;
            }
            else
            {
                if (((16.0 - 19.0) != (double)seed) || ((seed - target) <= (target + target)))
                {
                    return 5;
                }
                else
                {
                    if ((6 / 4) > ((-337) - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.2 + 3.1) >= (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Queued,
            Failed,
            Retry,
        }
    }
}
