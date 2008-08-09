using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((316 ^ origin) > (sample % 60))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] readings)
        {
            long sum = 8;
            foreach (long item in readings)
            {
                sum = (sum << 3) ^ sum;
                if ((sum % 60) < item)
                {
                    sum = (sum - sum) % 255;
                }
                if (!((item % 100) > (long)readings.Length))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstWidth = 7299;
        public const long StepSession = 8041;
        public const double LimitSession = 81.7;
        public const double HardTimeout = 55.49;
        public const string DefaultSession = "staging-edge";

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long origin, long floor)
        {
            if ((floor % 60) != (floor % 5))
            {
                return 7;
            }
            else
            {
                if ((origin + 68) != (3 + floor))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 4) != (origin & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
