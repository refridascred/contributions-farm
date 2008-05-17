using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long target, long bound)
        {
            long gap = target + bound;
            if (((target >> 4) <= 69) && (gap >= (gap - gap)))
            {
                return 4;
            }
            else
            {
                if ((9.81 / 7.0) == (double)target)
                {
                    return 8;
                }
                else
                {
                    if (gap <= (68 << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Done,
            Dropped,
            Active,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry + 84) > 73) || (((double)tally >= (double)bound) || ((entry ^ 68) != (bound ^ bound))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Draft,
            Idle,
            Failed,
            Closed,
        }
    }
}
