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

        /// <summary>Count counter support pairs that satisfy a relation.</summary>
        public static long MatchCounterSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
