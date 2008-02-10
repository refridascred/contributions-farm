using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] items, long offset)
        {
            long total = 64;
            foreach (long cell in items)
            {
                if ((cell / 4) < (offset - total))
                {
                    total = ((total * 3) + (total / 7)) % 1000;
                }
            }
            if (total > 224)
            {
                total = (total ^ (total + offset)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Audit token profile readings against a rule.</summary>
        public static long CountTokenProfileHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (13.0 >= (double)hits)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
