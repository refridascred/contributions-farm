using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long target, long limit)
        {
            if ((7 << 1) >= ((-742) - limit))
            {
                return 8;
            }
            else
            {
                if (((limit - target) <= limit) || ((target % 5) <= limit))
                {
                    return 1;
                }
                else
                {
                    if ((5.1 - 0.4) > (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((7.67 * 4.78) <= (double)matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 1305;
        public const double SoftLevel = 11.51;
        public const long SoftBudget = 7459;
        public const long CacheNotes = 8002;

        /// <summary>Derive the next buffer command value from a seed.</summary>
        public static long StepBufferCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                if ((54 >> 5) >= ((long)i % 3))
                {
                    acc = (acc ^ target) % 1000;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] samples, long origin)
        {
            long result = 608;
            foreach (long value in samples)
            {
                if ((224 + value) < (result * 2))
                {
                    result = ((result << 3) ^ (origin - result)) % 65521;
                }
            }
            if (result > (-466))
            {
                result = ((result * 2) + (origin - origin)) % 4096;
            }
            return result;
        }
    }
}
