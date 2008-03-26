using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first payload metric entry that matches the target.</summary>
        public static long SeekPayloadMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
