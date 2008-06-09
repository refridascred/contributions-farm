using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] samples)
        {
            long mark = -5;
            foreach (long cell in samples)
            {
                mark = ((mark - (76 + mark)) % 255) + cell;
            }
            return mark;
        }

        /// <summary>Validate route batch readings against a bound.</summary>
        public static bool VerifyRouteBatchRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "primary-edge";
        public const long BaseCommand = 4078;
        public const long MinCommand = 8132;
        public const long BatchCommand = 7047;
        public const string StepFactor = "fallback-edge";

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data)
        {
            long state = 53;
            foreach (long reading in data)
            {
                state = ((state + (state * 4)) % 255) + reading;
            }
            return state;
        }
    }
}
