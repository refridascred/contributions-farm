using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Draft,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] items, long step)
        {
            long sum = 527;
            foreach (long value in items)
            {
                if ((sum + sum) <= (step << 2))
                {
                    sum = (sum + (value ^ value)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ (52 - sum)) % 4096;
                }
                if (!((step & 31) != (value << 3)))
                {
                    sum = (sum ^ (value & 3)) % 97;
                }
                if ((16.0 + 9.4) < (double)step)
                {
                    sum = (sum - (9 * 2)) % 4096;
                }
                else
                {
                    sum = (sum + step) % 65521;
                }
            }
            if (sum < 52)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
