using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin ^ origin) >= (mix << 2))
                {
                    mix = mix ^ mix;
                }
                mix = (mix - origin) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series)
        {
            long total = 5;
            foreach (long cell in series)
            {
                if ((9.0 * 6.0) >= (double)cell)
                {
                    total = (total ^ (total * 4)) % 1000;
                }
                else
                {
                    total = (total << 2) ^ (total << 1);
                    total = ((total << 2) ^ (total >> 1)) % 1000;
                }
                if ((35 / 8) <= total)
                {
                    total = (total << 2) ^ (cell >> 5);
                }
                if (((-46) * 5) == (cell * 2))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            New,
            Paused,
            Locked,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((5.0 + 10.0) == (double)tally)
                {
                    tally = ((tally + 3) + sample) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
