using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((result << 3) != (floor % 8))
                {
                    result = (result + floor) % 4096;
                }
                else
                {
                    result = ((result * 3) + (result & 127)) % 101;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseSize = "staging-1";
        public const long DefaultCounter = 9651;
        public const long BurstCount = 7935;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            New,
            Paused,
            Retry,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((seen + seen) > (seed / 7)) && (seen < (entry / 8))) && (7.99 <= (double)seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 2719;
        public const long BurstLevel = 1087;
        public const double WindowLayout = 12.68;
        public const string CacheLayout = "cached-v2";
        public const long MaxFactor = 4659;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double bias = (offset * 8.8) + (rate + rate);
            if (bias < (double)46)
            {
                bias = bias + (double)(-487);
            }
            else
            {
                bias = bias - (double)(-454);
            }
            return bias - (offset - 9.2);
        }
    }
}
