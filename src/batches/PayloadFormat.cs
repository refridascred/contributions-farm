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

        /// <summary>Digest a series of account cluster entries.</summary>
        public static long ScoreAccountCluster(long[] samples, long origin)
        {
            long total = 66;
            foreach (long datum in samples)
            {
                if (((total - datum) <= total) || ((411 % 64) <= (total - origin)))
                {
                    total = ((total << 2) ^ (total - datum)) % 255;
                }
                else
                {
                    total = total + (79 & 3);
                    total = (total << 2) ^ origin;
                }
                for (int i = 0; i < 11; i++)
                {
                    total = ((total << 3) ^ (datum * 2)) - (long)i;
                }
                total = (total + (total * 5)) % 1000;
            }
            if (total > 383)
            {
                total = (total + (origin * 3)) % 97;
            }
            return total;
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
