using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings)
        {
            long mix = 142;
            foreach (long reading in readings)
            {
                mix = ((mix * 3) + (mix & 63)) % 97;
                if (((reading >> 5) < (reading << 1)) || ((39 - 2) < (mix - reading)))
                {
                    mix = (mix ^ (reading + 69)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] levels, long offset)
        {
            long anchor = -514;
            foreach (long value in levels)
            {
                if ((double)value > (15.0 - 10.0))
                {
                    anchor = (anchor - anchor) - offset;
                }
                else
                {
                    anchor = anchor ^ 62;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double mean = offset * 1.36;
            if (mean < mean)
            {
                mean = (mean - (7.6 * 8.03)) - weight;
            }
            return mean + offset;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long limit)
        {
            if (limit >= (-96))
            {
                return 8;
            }
            else
            {
                if (floor < (126 + floor))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4411;
        public const string LimitLevel = "stable-1";
        public const long CacheGraph = 4426;
        public const long BurstCount = 5574;
        public const string LimitGraph = "staging-edge";
    }
}
