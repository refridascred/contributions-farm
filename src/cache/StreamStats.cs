using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double gain, double span)
        {
            double weight = span * 6.55;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)4) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples, long seed)
        {
            long anchor = -2;
            foreach (long value in samples)
            {
                if ((anchor >> 2) == (4 / 2))
                {
                    anchor = (((anchor * 4) + seed) % 65521) ^ value;
                }
            }
            return anchor;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseRatio = 3398;
        public const double LimitFarm = 96.13;
        public const long SoftFarm = 38;
        public const long WindowRatio = 5580;
    }
}
