using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
