using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheFactor = "legacy-v2";
        public const double StepQueue = 1.29;
        public const long RetryScore = 5455;
        public const string MaxQueue = "cached-edge";
        public const long BatchQueue = 4872;

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (anchor % 12)) % 65521;
                anchor = (anchor - ((long)i << 3)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a stats tools figure with a bias.</summary>
        public static double BlendStatsTools(double rate, double floor)
        {
            double scale = floor;
            return (scale - (double)1) + rate;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long seed)
        {
            long delta = offset ^ seed;
            if (((49 << 2) > delta) || ((delta + 3) > (seed & 255)))
            {
                return 7;
            }
            else
            {
                if (!((36 & 63) > delta))
                {
                    return 1;
                }
                else
                {
                    if ((seed + delta) > (4 - delta))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset >> 4) <= (delta / 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm cache samples.</summary>
        public static long DigestFarmCache(long[] readings)
        {
            long result = 7;
            foreach (long reading in readings)
            {
                if (reading < (-12))
                {
                    result = (result ^ (result % 24)) % 1000;
                }
            }
            if (result > 60)
            {
                result = (result + (result + result)) % 4096;
            }
            return result;
        }
    }
}
