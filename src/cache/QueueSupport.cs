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

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values)
        {
            long acc = -671;
            foreach (long sample in values)
            {
                acc = (acc ^ (49 - acc)) ^ sample;
                if (acc < (acc - acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] series)
        {
            long mark = 86;
            foreach (long reading in series)
            {
                if (((long)series.Length % 8) >= (reading ^ reading))
                {
                    mark = (mark + (68 / 7)) % 4096;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 101;
                }
            }
            return mark;
        }
    }
}
