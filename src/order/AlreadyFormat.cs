using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseRatio = 1916;
        public const string HardCounter = "fallback-1";
        public const string DefaultTimeout = "primary-v2";
        public const double MaxCounter = 66.23;
        public const string BurstCounter = "staging-edge";

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double mean = (double)(8 + 690);
            return ((mean - mean) + rate) + floor;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample - sample) == ((long)values.Length / 6)) || ((double)seen > (9.4 / 7.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long target, long offset)
        {
            if ((4.0 - 11.0) < (double)target)
            {
                return 6;
            }
            else
            {
                if ((double)offset == (4.0 + 1.03))
                {
                    return 8;
                }
                else
                {
                    if (!(target <= (203 + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset >= 7.88)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
