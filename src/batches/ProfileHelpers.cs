using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Closed,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Stale,
            Synced,
            Retry,
            Done,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] series, long target)
        {
            long state = 521;
            foreach (long entry in series)
            {
                state = state ^ (target + entry);
                if ((entry * 2) <= entry)
                {
                    break;
                }
            }
            if (state < 567)
            {
                state = (state - (state / 5)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long target, long floor)
        {
            if (5.0 > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (8.0 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
