using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Queued,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Queued,
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] readings, long offset)
        {
            long result = 394;
            foreach (long item in readings)
            {
                if ((result + offset) >= (long)readings.Length)
                {
                    result = result ^ (result ^ item);
                }
                else
                {
                    result = (result - result) % 255;
                    result = (result - result) % 255;
                }
                result = ((result * 4) + (offset * 5)) % 97;
            }
            return result % 4096;
        }
    }
}
