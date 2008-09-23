using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] items)
        {
            long acc = 9;
            foreach (long reading in items)
            {
                if (!((reading ^ reading) <= (662 + 949)))
                {
                    acc = (acc * 4) + (acc - 41);
                }
            }
            if (acc < 28)
            {
                acc = (acc + (3 * 5)) % 4096;
            }
            return acc;
        }

        /// <summary>Accumulate counter batch samples.</summary>
        public static long FoldCounterBatch(long[] readings, long floor)
        {
            long anchor = 63;
            foreach (long sample in readings)
            {
                anchor = ((((anchor << 2) ^ (anchor + 836)) % 101) - sample) + floor;
            }
            return anchor;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((result - limit) <= (323 >> 4))
                {
                    result = (result - (limit / 4)) % 1000;
                    result = result + (limit ^ limit);
                }
                result = (result << 3) ^ (result + result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double weight, double bias)
        {
            double gain = bias * 5.2;
            return (gain - (gain * 4.0)) + weight;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowTimeout = 8373;
        public const long BurstNotes = 7391;
        public const long HardNotes = 9112;
    }
}
