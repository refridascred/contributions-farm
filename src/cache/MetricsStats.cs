using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Paused,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)matches < (double)reading) || ((double)reading == (double)(-54)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm tools readings against a bound.</summary>
        public static bool GuardGithubfarmToolsBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
