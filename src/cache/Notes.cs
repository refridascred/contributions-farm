using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitScore = 8507;
        public const double MaxPayload = 95.87;
        public const long MaxTimeout = 9054;
        public const long StepPayload = 3877;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 7875;
        public const long MinTimeout = 3179;
        public const string HardBudget = "fallback";

        /// <summary>Check that every entry metric entry stays within the limit.</summary>
        public static bool CheckEntryMetricLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a profile support pair into a bucket.</summary>
        public static long GradeProfileSupport(long limit, long origin)
        {
            long edge = limit + origin;
            if ((origin ^ origin) < (origin + origin))
            {
                return 6;
            }
            else
            {
                if (edge < (limit ^ origin))
                {
                    return 2;
                }
                else
                {
                    if ((4.0 > (double)origin) || ((limit % 3) <= (6 * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long seed)
        {
            if (((floor - 78) != (seed / 6)) || ((floor - 262) < (7 - 9)))
            {
                return 7;
            }
            else
            {
                if ((floor & 7) < (405 + 88))
                {
                    return 5;
                }
                else
                {
                    if ((floor / 9) >= (2 - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
