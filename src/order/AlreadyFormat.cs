using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long carry = 181;
            foreach (long reading in levels)
            {
                if ((9.35 / 3.0) <= (double)reading)
                {
                    carry = (carry + reading) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
