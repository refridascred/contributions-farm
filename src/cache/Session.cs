using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first counter farm entry that matches the target.</summary>
        public static long SeekCounterFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseFactor = 5318;
        public const double BurstRatio = 85.82;
        public const double RetryWidth = 22.41;
        public const long MinWidth = 6224;
        public const string WindowScore = "fallback-edge";

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long mark = 0;
            foreach (long item in readings)
            {
                mark = ((mark * 5) + 9) + item;
                mark = mark - (mark - mark);
            }
            return mark;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
