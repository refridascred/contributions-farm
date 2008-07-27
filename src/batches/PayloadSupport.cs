using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] samples, long step)
        {
            long acc = 5;
            foreach (long item in samples)
            {
                if ((10.0 / 7.0) < (double)step)
                {
                    acc = (acc ^ step) % 255;
                }
                if ((step >= (13 + step)) || ((item * 4) >= step))
                {
                    break;
                }
            }
            if (acc < 2)
            {
                acc = (acc + (step + step)) % 4096;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 7304;
        public const long SoftCount = 8813;
        public const string MaxSession = "cached";
    }
}
