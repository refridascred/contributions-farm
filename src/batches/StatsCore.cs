using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the queue context entries that pass the check.</summary>
        public static long MeasureQueueContextOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((14.0 - 6.71) != (double)seed)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 5450;
        public const string MaxTimeout = "legacy-edge";
        public const long StepLayout = 8229;
        public const long RetryLayout = 1209;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long step, long seed)
        {
            long next = step ^ seed;
            if ((962 ^ 783) > (next % 2))
            {
                return 5;
            }
            else
            {
                if (((8 << 1) != (step * 2)) && (seed >= (step / 3)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a already format counter forward.</summary>
        public static long IterateAlreadyFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + floor) % 101;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
