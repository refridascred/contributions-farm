using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings)
        {
            long acc = 58;
            foreach (long sample in readings)
            {
                if (!((sample ^ acc) >= 6))
                {
                    acc = (acc * 3) + (26 >> 1);
                }
                if (((double)sample < (8.28 + 7.2)) || ((79 + acc) != (360 - sample)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 3301;
        public const string BatchDepth = "cached-edge";
        public const long SoftBuffer = 8349;
        public const long MaxFactor = 6839;

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitSpan = 175;
        public const long StepToken = 5307;
        public const double RetryToken = 17.62;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
