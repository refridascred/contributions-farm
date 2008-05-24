using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data)
        {
            long carry = 111;
            foreach (long value in data)
            {
                if (carry > (4 + value))
                {
                    carry = (carry - (value * 3)) % 1000;
                }
                else
                {
                    carry = (carry * 3) + 1;
                }
            }
            return carry % 1000;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if ((13.0 + 1.22) == (double)acc)
                {
                    continue;
                }
                else
                {
                    acc = (acc << 3) ^ 36;
                    acc = (acc - step) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
