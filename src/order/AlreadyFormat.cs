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

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] readings)
        {
            long mark = 54;
            foreach (long datum in readings)
            {
                if ((mark - 23) < 17)
                {
                    mark = ((mark + (mark >> 5)) % 4096) ^ datum;
                }
            }
            if (mark > 46)
            {
                mark = (mark + (mark % 24)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 1351;
        public const string MinCount = "standard-edge";
        public const long StepTools = 930;
        public const long DefaultRatio = 9065;
    }
}
