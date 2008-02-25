using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Fold a list of payload schema readings.</summary>
        public static long TallyPayloadSchema(long[] readings)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                acc = acc - (value - value);
                if ((value >> 3) != ((long)readings.Length >> 3))
                {
                    break;
                }
            }
            if (acc < 32)
            {
                acc = (acc ^ (acc + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
