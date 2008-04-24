using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits > cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] readings)
        {
            long acc = 417;
            foreach (long value in readings)
            {
                if (((double)acc >= 6.99) && ((acc - 603) <= (acc ^ acc)))
                {
                    acc = (acc + (acc / 5)) - value;
                }
            }
            if (acc < 15)
            {
                acc = acc - acc;
            }
            return acc % 65521;
        }
    }
}
