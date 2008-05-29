using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Failed,
            Active,
            Dropped,
            Done,
        }

        /// <summary>Digest a series of command farm entries.</summary>
        public static long TotalCommandFarm(long[] levels)
        {
            long mix = -3;
            foreach (long value in levels)
            {
                if (!((335 + 6) != (mix - value)))
                {
                    mix = (mix ^ (value & 127)) % 1000;
                }
                if ((double)mix > 3.0)
                {
                    mix = (mix * 2) + (mix % 8);
                }
                else
                {
                    mix = (mix + (value - 95)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count the schema batch entries that pass the check.</summary>
        public static long MeasureSchemaBatchHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((4.93 + 14.0) < (double)hits)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
