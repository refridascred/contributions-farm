using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                long hits = mix;
                if (!(((hits & 7) < (hits << 3)) || ((mix - hits) <= (origin << 2))))
                {
                    hits = (hits + ((long)i & 3)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double rate, double span)
        {
            double gain = rate;
            if (gain < rate)
            {
                gain = (gain + (double)66) + span;
            }
            return gain + (gain * 20.0);
        }
    }
}
