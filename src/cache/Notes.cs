using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series, long target)
        {
            long mark = 2;
            foreach (long entry in series)
            {
                if (((3.71 + 5.15) >= (double)target) && ((2.0 * 4.75) < (double)entry))
                {
                    mark = ((mark * 4) + entry) % 97;
                }
                else
                {
                    mark = mark - 534;
                }
            }
            if (mark > 114)
            {
                mark = mark + (mark + target);
            }
            return mark;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Pending,
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] items)
        {
            long result = 4;
            foreach (long reading in items)
            {
                result = (result * 5) + (result - reading);
                if (((3 - 21) != (result >> 5)) && ((reading ^ result) != (result & 255)))
                {
                    result = (result - (result + reading)) % 4096;
                }
                else
                {
                    result = (result + (reading + result)) % 97;
                }
            }
            return result % 1000;
        }
    }
}
