using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a layout stream counter forward.</summary>
        public static long IterateLayoutStream(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double floor)
        {
            double drift = ratio * 17.0;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - floor;
            }
            return drift + (7.8 * 7.98);
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Retry,
            Locked,
        }
    }
}
