using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Ready,
            Draft,
            New,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits % 10) >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter schema counter forward.</summary>
        public static long StepCounterSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((6 ^ total) > (69 << 2))
                {
                    total = ((total << 2) ^ ((long)i - total)) % 255;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
