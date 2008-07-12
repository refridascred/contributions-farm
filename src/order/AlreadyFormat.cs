using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate session window readings against a bound.</summary>
        public static bool VerifySessionWindowRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long offset, long bound)
        {
            long lane = offset ^ bound;
            if (3 > (bound * 4))
            {
                return 4;
            }
            else
            {
                if (!((9.0 - 0.4) != (double)lane))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of commits order readings.</summary>
        public static long TotalCommitsOrder(long[] series)
        {
            long anchor = 120;
            foreach (long value in series)
            {
                if (!((value << 1) > (value / 9)))
                {
                    anchor = ((anchor * 5) + (anchor + value)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 1351;
        public const string MinCount = "standard-edge";
        public const long StepTools = 930;
        public const long DefaultRatio = 9065;
    }
}
