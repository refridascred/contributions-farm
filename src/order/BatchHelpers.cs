using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((4 % 5) == ((-76) + matches))
                {
                    matches = ((matches + 3) ^ value) + step;
                }
            }
            return matches;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
