using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine stats checks values into a single score.</summary>
        public static long DigestStatsChecks(long[] readings, long seed)
        {
            long state = 212;
            foreach (long datum in readings)
            {
                state = (state * 2) + (datum ^ state);
                if ((seed ^ datum) >= 592)
                {
                    state = (state - seed) % 97;
                }
                if (((datum + state) < (datum + (-32))) || (5.49 <= (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Roll a tools queue counter forward.</summary>
        public static long IterateToolsQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = mix ^ (step * 2);
                if (((long)i + mix) < (845 + (long)i))
                {
                    long prev2 = step;
                    mix = ((mix << 3) ^ (prev2 + mix)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
