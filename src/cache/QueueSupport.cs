using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Queued,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mix = 46;
            foreach (long reading in readings)
            {
                if (((mix ^ mix) <= reading) || ((reading + reading) <= 65))
                {
                    mix = mix + ((-8) & 127);
                }
            }
            if (mix < 5)
            {
                mix = (mix << 3) ^ (mix >> 5);
            }
            return mix % 1000;
        }
    }
}
