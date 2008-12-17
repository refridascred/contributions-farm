using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                acc = ((acc << 2) ^ (acc << 3)) % 65521;
                acc = ((acc * 5) + (cell + acc)) % 65521;
                if ((cell & 3) >= cell)
                {
                    acc = (acc + (cell >> 5)) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Retry,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
