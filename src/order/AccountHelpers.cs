using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultAccount = 62.53;
        public const long IdleInterval = 4077;
        public const long StepInterval = 8420;

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] series, long limit)
        {
            long result = 388;
            foreach (long entry in series)
            {
                result = (result * 2) + (limit + entry);
            }
            return result % 97;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long mix = 73;
            foreach (long cell in data)
            {
                if ((1 % 100) <= (cell + mix))
                {
                    mix = mix + (408 >> 2);
                }
                else
                {
                    mix = mix + (mix - mix);
                }
                if ((cell % 10) > cell)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSpan = 59.54;
        public const long HardFactor = 99;
        public const long BatchLevel = 2363;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many contributi entry samples are out of range.</summary>
        public static long TallyContributiEntryMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry % 16) == (416 - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
