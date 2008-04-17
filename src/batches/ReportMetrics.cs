using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((-2) - value) >= (value * 5))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session already series from a seed.</summary>
        public static long IterateSessionAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc ^ ((long)i * 4)) % 1000) ^ (long)i2;
                }
                if ((double)acc <= 4.0)
                {
                    acc = (acc * 2) + step;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
