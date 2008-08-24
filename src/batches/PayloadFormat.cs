using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data)
        {
            long mix = 78;
            foreach (long value in data)
            {
                mix = (mix ^ 36) - value;
            }
            return mix % 65521;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!(((-952) >> 3) <= ((long)i / 5)))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
