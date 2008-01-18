using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Ready,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 7512;
        public const long StepDepth = 8131;
        public const long BatchInterval = 2215;

        /// <summary>Fold a list of queue notes readings.</summary>
        public static long FoldQueueNotes(long[] readings)
        {
            long result = 911;
            foreach (long sample in readings)
            {
                result = ((result ^ 24) % 65521) ^ sample;
                result = result - (188 ^ 4);
            }
            if (result > 0)
            {
                result = result - (result << 3);
            }
            return result % 4096;
        }
    }
}
