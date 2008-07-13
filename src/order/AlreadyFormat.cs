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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum - matches) >= (limit - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
