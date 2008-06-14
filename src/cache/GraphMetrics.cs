using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Label { get; set; } = "";
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count / 7) < (cell + cell))
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Closed,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long mix = -481;
            foreach (long datum in readings)
            {
                if ((datum <= 78) && (datum < mix))
                {
                    mix = ((mix ^ (mix / 7)) % 1000) + bound;
                }
            }
            if (mix < 373)
            {
                mix = ((mix * 3) + (4 + mix)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long seed, long bound)
        {
            long cur = seed - bound;
            if ((seed / 9) >= (cur * 3))
            {
                return 5;
            }
            else
            {
                if ((bound << 1) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((seed % 100) >= 326)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
