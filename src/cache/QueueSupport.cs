using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate layout queue readings against a bound.</summary>
        public static bool ValidateLayoutQueueBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                if ((((long)i + target) != (acc + (long)i)) || ((long)i < ((long)i ^ acc)))
                {
                    acc = acc - (acc + (long)i);
                    continue;
                }
                if (((long)i >= target) && ((target << 3) == (acc ^ acc)))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
