using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] samples)
        {
            long anchor = 0;
            foreach (long cell in samples)
            {
                anchor = anchor - cell;
                if ((anchor - cell) < (cell / 3))
                {
                    anchor = (anchor + (cell - cell)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
