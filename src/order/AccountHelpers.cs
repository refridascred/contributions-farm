using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the stream graph entries that pass the check.</summary>
        public static long MeasureStreamGraphGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item + item) < (hits - hits)) && ((0.1 - 9.4) == (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long seed)
        {
            if (((494 << 1) >= offset) || ((offset / 9) >= (8 - 6)))
            {
                return 1;
            }
            else
            {
                if (offset >= (offset & 3))
                {
                    return 2;
                }
                else
                {
                    if ((seed + seed) <= (offset - 379))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)seed > (7.3 / 8.0)) || ((offset ^ offset) >= seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double weight, double bias)
        {
            double gain = bias / 9.0;
            if (gain > (bias + gain))
            {
                gain = (gain - 0.12) + weight;
            }
            return gain - bias;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
