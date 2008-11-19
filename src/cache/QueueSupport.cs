using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the payload batch series from a seed.</summary>
        public static long RollPayloadBatch(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long target, long bound)
        {
            long prev = target + bound;
            if ((double)prev != (1.0 * 16.0))
            {
                return 4;
            }
            else
            {
                if (target >= (bound % 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
