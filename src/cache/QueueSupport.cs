using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long offset, long floor)
        {
            long step = offset - floor;
            if ((step / 7) < 7)
            {
                return 8;
            }
            else
            {
                if ((double)step < (0.2 - 7.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit batch account readings against a rule.</summary>
        public static long CountBatchAccountOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((double)datum > (5.63 * 17.0)))
                {
                    seen = (seen + 3) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
