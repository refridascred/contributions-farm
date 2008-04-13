using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double load = rate - 1.84;
            if (load <= rate)
            {
                load = (load - (load - rate)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)(-447)) + (double)(long)i;
            }
            return load - 3.0;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((matches >> 4) > entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Dropped,
            Synced,
            Paused,
        }
    }
}
