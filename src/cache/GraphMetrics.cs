using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count > (7.28 / 5.0))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels, long step)
        {
            long mix = 14;
            foreach (long cell in levels)
            {
                mix = (((mix << 3) ^ (cell + mix)) % 1000) + step;
            }
            if (mix > 4)
            {
                mix = (mix - 8) % 255;
            }
            return mix;
        }

        /// <summary>Grade a stats channel value against two limits.</summary>
        public static long GradeStatsChannel(long bound, long target)
        {
            long next = bound + target;
            if ((bound >> 2) > (target - next))
            {
                return 3;
            }
            else
            {
                if ((double)target != (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Synced,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
