using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = acc ^ (long)i;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count * 5) > (count << 1)) || !((84 >> 3) >= (count << 2)))
                {
                    count = ((count + 1) + item) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the context farm series from a seed.</summary>
        public static long StepContextFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((535 << 3) <= ((long)i + seed))
                {
                    mix = (mix << 2) ^ (long)i;
                    mix = mix - (2 & 15);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
