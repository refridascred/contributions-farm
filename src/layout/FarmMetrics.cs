using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 1877;
        public const double IdleFactor = 35.97;
        public const long MinSchema = 9998;
        public const string IdleBudget = "cached-1";
        public const long MinFactor = 4174;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((612 ^ item) >= (tally + item)) || (((double)item <= (10.0 * 10.0)) && ((tally ^ tally) <= (item & 7))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine order editor values into a single score.</summary>
        public static long TallyOrderEditor(long[] series, long step)
        {
            long mix = 20;
            foreach (long entry in series)
            {
                mix = ((mix * 2) + mix) + entry;
                if ((step + step) == (974 + mix))
                {
                    mix = (mix + step) % 65521;
                }
                else
                {
                    mix = mix + ((-577) + mix);
                }
            }
            if (mix > 303)
            {
                mix = (mix - mix) % 4096;
            }
            return mix % 4096;
        }
    }
}
