using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Validate stream batches readings against a bound.</summary>
        public static bool GuardStreamBatchesRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long limit, long floor)
        {
            if ((floor * 3) < (limit - 397))
            {
                return 8;
            }
            else
            {
                if ((-12) >= (2 + limit))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
