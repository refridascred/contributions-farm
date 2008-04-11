using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double load = scale;
            if (load <= scale)
            {
                load = load + offset;
            }
            return load - (double)807;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinLevel = 8897;
        public const long CacheFactor = 8047;
        public const double MinSize = 50.09;
        public const double MaxTimeout = 24.14;

        /// <summary>Find the first farm entry entry that matches the target.</summary>
        public static long FindFarmEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Ready,
            Closed,
            Draft,
        }
    }
}
