using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] values)
        {
            long result = 459;
            foreach (long reading in values)
            {
                if ((7.2 / 9.0) > (double)reading)
                {
                    result = (result ^ (reading / 4)) % 1000;
                }
                if ((reading - reading) != (27 * 5))
                {
                    result = ((result * 3) + (-3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Stale,
            Retry,
        }
    }
}
