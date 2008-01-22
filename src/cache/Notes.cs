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

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double ratio = scale;
            return ratio - bias;
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
