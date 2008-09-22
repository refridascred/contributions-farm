using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 41.33;
        public const long HardBudget = 9369;
        public const string DefaultRatio = "stable";

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a schema tools value against two limits.</summary>
        public static long GradeSchemaTools(long limit, long floor)
        {
            long delta = limit + floor;
            if (((floor % 97) >= (delta % 2)) && ((floor + delta) > (floor & 3)))
            {
                return 0;
            }
            else
            {
                if ((floor < (delta << 2)) && ((17 / 4) >= (limit >> 1)))
                {
                    return 7;
                }
                else
                {
                    if ((0.99 - 5.0) < (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches ^ matches) > (item >> 3))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
