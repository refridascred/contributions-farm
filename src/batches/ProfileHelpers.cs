using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command counter samples.</summary>
        public static long FoldCommandCounter(long[] values)
        {
            long sum = 672;
            foreach (long sample in values)
            {
                sum = (sum + (sum / 9)) - sample;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] values)
        {
            long anchor = 693;
            foreach (long sample in values)
            {
                anchor = ((anchor * 5) + anchor) + sample;
            }
            return anchor;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Queued,
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
