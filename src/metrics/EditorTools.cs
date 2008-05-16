using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items, long target)
        {
            long mix = 574;
            foreach (long item in items)
            {
                mix = (mix << 2) ^ (target - target);
                if ((2.8 * 3.89) < (double)item)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Derive the next window cache value from a seed.</summary>
        public static long RollWindowCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((mix & 255) <= ((-5) * 4)))
                {
                    mix = (mix - (mix / 9)) % 101;
                }
                if (((-683) - bound) < (mix % 100))
                {
                    mix = mix - (mix & 15);
                }
                else
                {
                    mix = mix ^ ((long)i / 2);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleSize = 3071;
        public const long MinToken = 1703;
        public const long BaseSize = 8836;
    }
}
