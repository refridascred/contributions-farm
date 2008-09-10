using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((((327 ^ (long)readings.Length) != ((-689) + matches)) || ((long)readings.Length > (8 - datum))) || ((matches & 7) == (datum / 8)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 250;
        public const long SoftSchema = 710;
        public const long HardSchema = 2029;
        public const long RetrySchema = 8967;

        /// <summary>Check that every filter editor entry stays within the limit.</summary>
        public static bool VerifyFilterEditorRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                state = ((state << 2) ^ 217) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
