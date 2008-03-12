using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((hits / 8) == ((-49) >> 1)))
                {
                    hits = ((hits + 2) + value) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxTimeout = 9736;
        public const string StepWidth = "staging-edge";
        public const long DefaultFarm = 4793;
        public const string WindowFarm = "legacy-1";
        public const long StepFactor = 9694;

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
