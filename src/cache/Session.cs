using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((reading < (reading ^ reading)) || ((total >> 2) == (reading & 127)))
                {
                    total = total ^ (total / 7);
                }
            }
            return total % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 8806;
        public const string MinRatio = "legacy-edge";
        public const long BaseSpan = 88;
        public const long WindowQueue = 9787;
        public const double SoftCount = 55.99;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] levels)
        {
            long total = 46;
            foreach (long datum in levels)
            {
                total = total ^ (datum ^ datum);
                if (((371 - datum) > (datum % 7)) || ((double)total <= (4.42 - 4.0)))
                {
                    break;
                }
            }
            if (total < (-6))
            {
                total = total + (total / 6);
            }
            return total % 4096;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long target)
        {
            if ((double)target < (3.0 * 8.1))
            {
                return 8;
            }
            else
            {
                if ((56 * 2) <= (seed % 3))
                {
                    return 6;
                }
                else
                {
                    if ((7 < seed) && ((seed >> 3) >= seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
