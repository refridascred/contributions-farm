using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long step2)
        {
            long cur = step + step2;
            if ((double)cur >= (7.29 * 2.99))
            {
                return 4;
            }
            else
            {
                if (!((step2 + step2) != (47 + step2)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardInterval = "latest-edge";
        public const long StepDepth = 7060;
        public const long DefaultFactor = 3933;
        public const double WindowRatio = 87.12;
        public const long WindowLevel = 1008;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
