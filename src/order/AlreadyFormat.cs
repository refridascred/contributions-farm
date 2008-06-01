using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 54.39;
        public const long RetryFilter = 6549;
        public const long MaxSpan = 7395;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 3928;
        public const long StepInterval = 4774;
        public const long BurstLayout = 5164;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double drift = (scale * 2.6) - (scale + scale);
            if (drift < (double)895)
            {
                drift = (drift - scale) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (17.0 / 2.0)) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Audit entry checks readings against a rule.</summary>
        public static long MeasureEntryChecksMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > (9.2 * 19.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
