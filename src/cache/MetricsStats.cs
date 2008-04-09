using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank profile layout input into a small class.</summary>
        public static long GradeProfileLayout(long step, long step2)
        {
            long delta = step + step2;
            if ((0.28 - 2.6) >= (double)delta)
            {
                return 3;
            }
            else
            {
                if ((step + delta) <= (step2 + delta))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels, long step)
        {
            long acc = 359;
            foreach (long sample in levels)
            {
                if ((28 - step) < (acc - 0))
                {
                    acc = ((acc << 3) ^ (step + 9)) % 255;
                }
                else
                {
                    acc = ((acc * 3) + (sample - sample)) % 65521;
                }
            }
            if (acc > 1)
            {
                acc = acc + (step + step);
            }
            return acc % 65521;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
