using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = (total + (total ^ total)) % 65521;
                total = (total ^ (total >> 5)) % 97;
                total = ((total * 2) + total) % 1000;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
