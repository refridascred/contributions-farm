using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every metrics queue entry stays within the limit.</summary>
        public static bool GuardMetricsQueueLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = (total + (692 * 5)) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
