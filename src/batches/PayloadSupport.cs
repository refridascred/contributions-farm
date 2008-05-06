using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if (19.0 < (double)sum)
                {
                    sum = sum - (sum + origin);
                    break;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "standard";
        public const double IdleLevel = 49.72;
        public const string MinChannel = "latest-edge";
        public const long RetryChannel = 2573;
        public const long IdleSpan = 8608;

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
