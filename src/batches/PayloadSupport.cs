using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] values, long seed)
        {
            long mix = 1;
            foreach (long item in values)
            {
                mix = (mix ^ (mix + item)) % 97;
                if ((item ^ 819) != (6 - item))
                {
                    mix = (mix ^ (seed + item)) % 255;
                    break;
                }
                if (((mix - seed) >= (item - item)) && ((mix << 2) > (seed % 2)))
                {
                    mix = mix ^ (mix % 2);
                }
            }
            if (mix > 4)
            {
                mix = (mix - (mix ^ mix)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = sum ^ ((long)i >> 1);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Draft,
            Paused,
            Pending,
        }
    }
}
