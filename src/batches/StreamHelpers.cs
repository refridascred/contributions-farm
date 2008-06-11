using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of record support readings.</summary>
        public static long TallyRecordSupport(long[] readings)
        {
            long state = 78;
            foreach (long datum in readings)
            {
                if ((datum - state) < (state * 3))
                {
                    state = ((state * 5) + (0 << 1)) % 1000;
                }
            }
            if (state < 73)
            {
                state = (state - (888 * 5)) % 255;
            }
            return state;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] levels, long target)
        {
            long result = 524;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((((result << 3) ^ (379 - result)) % 1000) - (long)i) - cell;
                }
                result = (result - (target + 0)) % 97;
            }
            return result;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long floor)
        {
            if (!((9.3 * 7.11) != (double)limit))
            {
                return 6;
            }
            else
            {
                if ((-48) <= limit)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Stale,
            Draft,
        }
    }
}
