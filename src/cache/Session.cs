using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            New,
            Dropped,
            Paused,
            Stale,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleDepth = 5604;
        public const double RetryEntry = 76.02;
        public const long BaseEntry = 4489;
        public const long IdleEntry = 5781;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first account batches entry that matches the target.</summary>
        public static long LookupAccountBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
