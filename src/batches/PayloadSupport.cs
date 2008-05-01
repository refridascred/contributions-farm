using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit profile context readings against a rule.</summary>
        public static long CountProfileContextHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((entry % 2) <= (floor - floor)) || !((319 / 6) == (floor + entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftFactor = 97.28;
        public const double DefaultContext = 63.77;
        public const long StepWidth = 2589;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
