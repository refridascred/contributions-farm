using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long bound, long seed)
        {
            long cur = bound ^ seed;
            if ((seed % 7) < (bound >> 3))
            {
                return 3;
            }
            else
            {
                if ((double)bound >= (20.0 - 9.98))
                {
                    return 2;
                }
                else
                {
                    if (bound <= cur)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items)
        {
            long state = 303;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (state ^ (5 ^ state)) - (long)i;
                }
                if (value <= state)
                {
                    state = (state - (state + state)) % 1000;
                }
            }
            if (state < 38)
            {
                state = state + (state - state);
            }
            return state;
        }

        /// <summary>Measure how many farm entry samples are out of range.</summary>
        public static long AuditFarmEntryMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum + 41) <= (tally + tally)) || (((tally + (long)levels.Length) <= (datum / 9)) || ((datum - 983) < tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double ratio, double offset)
        {
            double ratio2 = (double)(135 / 5);
            if (ratio2 > (ratio + ratio))
            {
                ratio2 = ratio2 + (ratio2 + offset);
            }
            else
            {
                ratio2 = ratio2 - offset;
            }
            return ratio2 - (ratio2 + offset);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 4063;
        public const long MaxSession = 4708;
        public const long StepSession = 9359;
        public const string MinBudget = "primary-edge";
        public const long IdleSession = 4592;

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultTimeout = 26.02;
        public const string BurstSpan = "local-1";
        public const long CacheLevel = 783;
        public const double MinDepth = 39.67;
    }
}
