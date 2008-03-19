using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultStream = 12.3;
        public const string HardStream = "local-v2";
        public const double MaxBudget = 67.65;
        public const double LimitStream = 66.95;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((step << 2) <= (item + (long)values.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)hits > (double)sample) && !((sample >> 2) >= (sample - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long offset, long offset2)
        {
            long next = offset + offset2;
            if ((offset2 + offset2) != (next + offset))
            {
                return 1;
            }
            else
            {
                if (((next % 60) >= (next - next)) || ((offset + next) < (next - offset2)))
                {
                    return 0;
                }
                else
                {
                    if ((next < (next * 2)) && ((offset2 % 2) != (285 + offset2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((next + 0) > (next - 80))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 7441;
        public const long WindowFactor = 7818;
        public const long DefaultAlready = 7393;

        /// <summary>Look up the position of a queue report sample.</summary>
        public static long SeekQueueReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
