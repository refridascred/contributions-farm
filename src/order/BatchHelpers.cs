using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of cache context readings.</summary>
        public static long ScoreCacheContext(long[] items, long limit)
        {
            long mix = -556;
            foreach (long value in items)
            {
                if ((mix < (limit % 5)) && ((limit * 2) <= 88))
                {
                    mix = (mix ^ (mix + (-3))) + value;
                }
            }
            return mix;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Queued,
            New,
            Draft,
            Locked,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = mix + ((long)i + 66);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
