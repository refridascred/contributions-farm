using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a schema entry counter forward.</summary>
        public static long IterateSchemaEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset < (offset + (long)i)) && ((-939) < (offset + offset)))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 8872;
        public const long HardScore = 5427;
        public const long MaxCommits = 5491;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if (!(bound <= mix))
                {
                    mix = (mix - 3) % 97;
                    mix = (mix << 2) ^ (bound - (long)i);
                }
                mix = mix ^ (bound ^ mix);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (mix << 3) ^ ((long)i2 + (long)i2);
                    mix = (mix << 3) ^ bound;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Retry,
            Locked,
        }
    }
}
