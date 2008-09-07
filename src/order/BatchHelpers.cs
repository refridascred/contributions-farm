using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a metric stream value against two limits.</summary>
        public static long SortMetricStream(long step, long floor)
        {
            if ((floor >= (step * 4)) && (91 > (step & 7)))
            {
                return 6;
            }
            else
            {
                if (((step + step) >= (42 * 4)) && ((step % 16) <= step))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
