using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine entry order values into a single score.</summary>
        public static long DigestEntryOrder(long[] readings)
        {
            long acc = 320;
            foreach (long value in readings)
            {
                acc = (acc - (acc + acc)) ^ value;
            }
            if (acc < 5)
            {
                acc = acc ^ (acc ^ 5);
            }
            return acc;
        }
    }
}
