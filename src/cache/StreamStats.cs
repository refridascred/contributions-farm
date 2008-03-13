using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                if (target > (7 - total))
                {
                    total = total - target;
                }
                else
                {
                    total = total ^ ((long)i / 6);
                }
                total = (total * 2) + (total + 199);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardTimeout = 5113;
        public const long BurstFormat = 6759;
        public const string BatchFormat = "fallback-v2";
        public const string BurstWidth = "cached-edge";

        /// <summary>Derive the next session farm value from a seed.</summary>
        public static long DeriveSessionFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                long slot = (step - (-5)) + (38 - step);
                if (!((double)(long)i <= (double)slot))
                {
                    slot = (slot - ((long)i + step)) % 101;
                    continue;
                }
                else
                {
                    total = ((total << 2) ^ (slot + (long)i)) % 1000;
                }
                slot = slot - (step + total);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values)
        {
            long acc = 306;
            foreach (long cell in values)
            {
                acc = ((acc ^ (acc - acc)) % 4096) + cell;
            }
            return acc;
        }
    }
}
