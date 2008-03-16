using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Idle,
            Failed,
            Done,
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double span)
        {
            double gain = rate + 9.87;
            if (gain <= (rate - gain))
            {
                gain = (gain + 3.4) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (gain / 8.0)) + (double)(long)i;
            }
            return gain + (1.0 / 6.0);
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long bound)
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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long limit, long step)
        {
            long offset = limit + step;
            if ((offset % 10) < (step + 47))
            {
                return 2;
            }
            else
            {
                if ((step + 288) == (1 >> 5))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit stats tools readings against a rule.</summary>
        public static long MeasureStatsToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(17.0 >= (double)count))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Synced,
            Closed,
        }
    }
}
