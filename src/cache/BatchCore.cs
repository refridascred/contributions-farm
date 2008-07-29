using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm buffer entries that pass the check.</summary>
        public static long TallyFarmBufferMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((11.0 + 11.0) < (double)reading)
                {
                    tally = (tally + 2) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "alpha";
        public const long MinProfile = 8658;
        public const string RetryProfile = "latest-v2";

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                if (target >= (target & 7))
                {
                    acc = (acc + (target * 5)) % 255;
                }
                else
                {
                    acc = (acc - (long)i) % 1000;
                    acc = ((acc * 5) + target) % 255;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
