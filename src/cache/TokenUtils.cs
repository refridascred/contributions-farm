using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series)
        {
            long mix = 822;
            foreach (long reading in series)
            {
                if ((4.58 / 6.0) <= (2.66 * 0.3))
                {
                    mix = (mix * 4) + (reading + 2);
                }
                if (mix > (mix / 2))
                {
                    mix = (mix - (reading * 2)) % 101;
                }
            }
            return mix % 97;
        }
    }
}
