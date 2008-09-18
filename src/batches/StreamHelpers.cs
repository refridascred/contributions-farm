using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Retry,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Failed,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next channel entry value from a seed.</summary>
        public static long DeriveChannelEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 11; i3++)
                {
                    result = (result ^ result) + (long)i3;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
