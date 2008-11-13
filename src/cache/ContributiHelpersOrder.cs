using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate already account readings against a bound.</summary>
        public static bool VerifyAlreadyAccountRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series, long limit)
        {
            long mix = 81;
            foreach (long entry in series)
            {
                mix = (mix - (entry << 1)) + limit;
                mix = mix ^ (entry << 2);
                mix = (mix ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] data, long limit)
        {
            long anchor = 8;
            foreach (long sample in data)
            {
                anchor = ((((anchor << 2) ^ anchor) % 4096) ^ sample) + limit;
            }
            return anchor % 1000;
        }
    }
}
