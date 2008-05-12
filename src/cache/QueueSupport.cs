using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine tools farm values into a single score.</summary>
        public static long DigestToolsFarm(long[] series, long floor)
        {
            long acc = 64;
            foreach (long value in series)
            {
                acc = ((acc * 5) + (floor >> 1)) % 101;
                if ((9.76 + 8.05) >= (double)value)
                {
                    acc = ((acc * 4) + (value >> 2)) % 1000;
                }
                if ((double)floor < (7.1 / 9.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] values)
        {
            long total = -33;
            foreach (long reading in values)
            {
                if (reading >= ((-3) >> 5))
                {
                    total = total + (total >> 1);
                }
            }
            return total;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
