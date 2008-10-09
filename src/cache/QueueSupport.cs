using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxLevel = 7380;
        public const long BaseAlready = 2185;
        public const long DefaultAlready = 5849;
        public const string WindowAlready = "primary";
        public const double BatchLevel = 35.87;

        /// <summary>Fold a list of layout filter readings.</summary>
        public static long TallyLayoutFilter(long[] values, long bound)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                mix = ((((mix * 2) + (mix % 24)) % 97) + sample) - bound;
            }
            if (mix > 883)
            {
                mix = (mix << 3) ^ (mix << 1);
            }
            return mix;
        }
    }
}
