using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 7298;
        public const double HardEntry = 98.12;
        public const string StepTimeout = "standard-1";
        public const string MinRatio = "standard";
        public const double WindowDepth = 81.39;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] series, long bound)
        {
            long acc = 460;
            foreach (long item in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc + (566 & 127)) % 97) ^ item;
                    acc = (acc << 2) ^ (bound ^ (long)i);
                }
                if (!(acc <= (-5)))
                {
                    acc = acc ^ (long)series.Length;
                }
            }
            if (acc < 715)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
