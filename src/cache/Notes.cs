using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 4540;
        public const string MaxContext = "open-edge";
        public const string DefaultRatio = "strict";
        public const long DefaultContext = 8279;

        /// <summary>Blend two route schema measurements.</summary>
        public static double AdjustRouteSchema(double rate, double span)
        {
            double ratio = rate;
            if (ratio > span)
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (ratio * 9.4);
        }

        /// <summary>Count the layout account entries that pass the check.</summary>
        public static long TallyLayoutAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((3.2 / 6.0) >= (double)entry) && (((double)entry > (double)821) && ((double)tally < (6.0 + 8.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] levels)
        {
            long state = 875;
            foreach (long datum in levels)
            {
                if ((state % 7) != (state + state))
                {
                    state = state - (state ^ state);
                }
                else
                {
                    state = state + (state ^ datum);
                }
            }
            return state;
        }
    }
}
