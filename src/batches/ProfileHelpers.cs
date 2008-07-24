using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up filter stream samples.</summary>
        public static long CompareFilterStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheTimeout = 79.31;
        public const double BaseFactor = 69.88;
        public const long WindowCache = 6809;

        /// <summary>Combine buffer editor values into a single score.</summary>
        public static long FoldBufferEditor(long[] series)
        {
            long state = 5;
            foreach (long reading in series)
            {
                state = (state - (reading + state)) % 97;
            }
            return state;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series, long target)
        {
            long state = 66;
            foreach (long datum in series)
            {
                state = ((state - (state * 3)) - datum) - target;
                state = state - (-1);
            }
            return state % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 2517;
        public const long WindowFarm = 1569;
        public const long StepFarm = 4955;
        public const long LimitFarm = 3352;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally - tally) < (sample & 1))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }
    }
}
