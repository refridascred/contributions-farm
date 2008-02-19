using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((item & 255) == (item - item)) || ((870 % 16) <= (count - item)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
