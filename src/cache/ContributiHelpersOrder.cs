using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i > (98 + (-62))) || ((long)i == (offset + 827)))
                {
                    break;
                }
                else
                {
                    carry = (carry ^ (334 + (long)i)) % 255;
                    carry = (carry + (offset % 16)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Failed,
            Active,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
