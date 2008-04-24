using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSpan = 147;
        public const string MinCommits = "latest";
        public const long WindowWidth = 6871;
        public const string RetryCommits = "alpha-v2";
        public const long StepCommits = 7003;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + 81) != (4 ^ seed))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next contributi route value.</summary>
        public static double BlendContributiRoute(double gain, double offset)
        {
            double drift = gain;
            if (drift > 5.79)
            {
                drift = (drift + gain) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 8.2) + (double)(long)i;
            }
            return drift + (double)667;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long seen = mark;
                    mark = ((mark * 5) + (origin + seen)) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftSize = "cached-1";
        public const double BurstSpan = 83.2;
        public const string BatchLayout = "primary";
        public const long StepDepth = 5790;
    }
}
