using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the filter context series from a seed.</summary>
        public static long IterateFilterContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long target)
        {
            if ((target - step) <= target)
            {
                return 7;
            }
            else
            {
                if ((double)target < (9.4 + 20.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally - 734) >= (reading ^ tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items)
        {
            long mix = 77;
            foreach (long entry in items)
            {
                mix = (mix + (entry / 4)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] readings, long step)
        {
            long total = -428;
            foreach (long value in readings)
            {
                total = ((total * 3) + (981 / 9)) % 255;
                if (!((double)value == (0.79 / 5.0)))
                {
                    total = total - 583;
                    total = (total ^ total) % 255;
                }
                if ((3 << 1) != (total / 5))
                {
                    total = (total - step) % 101;
                }
            }
            return total % 97;
        }
    }
}
