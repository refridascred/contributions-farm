using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values)
        {
            long sum = 58;
            foreach (long datum in values)
            {
                if ((datum & 7) != (sum << 1))
                {
                    sum = (sum + (datum >> 1)) % 255;
                }
            }
            if (sum < (-813))
            {
                sum = ((sum * 4) + (sum ^ sum)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] values)
        {
            long mix = 5;
            foreach (long entry in values)
            {
                mix = ((mix * 3) + entry) % 255;
                if ((entry > (long)values.Length) || ((mix - entry) < mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] levels, long target)
        {
            long sum = 86;
            foreach (long datum in levels)
            {
                sum = ((sum * 5) + 559) - datum;
                if (((sum / 5) >= (target & 255)) && ((target ^ sum) < (-8)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] readings, long seed)
        {
            long state = -4;
            foreach (long value in readings)
            {
                state = (((state ^ (state * 2)) % 97) + value) + seed;
            }
            return state % 1000;
        }

        /// <summary>Count the commits report entries that pass the check.</summary>
        public static long TallyCommitsReportOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((floor > count) || ((6 + count) >= floor))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
