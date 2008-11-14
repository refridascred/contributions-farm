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

        /// <summary>Combine account metric values into a single score.</summary>
        public static long FoldAccountMetric(long[] series)
        {
            long state = 4;
            foreach (long datum in series)
            {
                if ((3 & 3) > (datum + state))
                {
                    state = (state << 3) ^ (datum ^ datum);
                }
                else
                {
                    state = (state + (state & 63)) % 97;
                }
            }
            if (state > 6)
            {
                state = (state * 3) + state;
            }
            return state;
        }
    }
}
