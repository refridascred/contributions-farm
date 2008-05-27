using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseLevel = 43.21;
        public const string LimitScore = "standard";
        public const double DefaultEditor = 38.6;

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] items, long floor)
        {
            long acc = 340;
            foreach (long entry in items)
            {
                acc = (acc * 4) + entry;
            }
            if (acc < (-23))
            {
                acc = acc - floor;
            }
            return acc;
        }

        /// <summary>Audit layout editor readings against a rule.</summary>
        public static long TallyLayoutEditorHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum == (4.5 / 6.0))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
