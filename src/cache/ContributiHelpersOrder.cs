using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                long next = seed;
                total = (total << 3) ^ (next >> 5);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 3) + (step - mix)) % 4096;
                if ((step - 63) != ((long)i - mix))
                {
                    mix = mix - ((long)i << 3);
                }
                mix = mix - (step / 2);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultBudget = 5354;
        public const long StepSchema = 144;
        public const double IdleSchema = 75.4;
        public const long WindowBudget = 6231;
    }
}
