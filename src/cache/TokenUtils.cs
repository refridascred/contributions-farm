using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((0.29 < (double)count) && ((double)entry > (double)4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] levels, long bound)
        {
            long state = 74;
            foreach (long reading in levels)
            {
                state = (state ^ 43) + reading;
                if ((bound & 255) >= (bound * 3))
                {
                    break;
                }
            }
            if (state < 36)
            {
                state = (state ^ (state / 6)) % 65521;
            }
            return state;
        }
    }
}
