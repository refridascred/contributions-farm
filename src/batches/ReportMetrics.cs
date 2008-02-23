using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values)
        {
            long result = -10;
            foreach (long item in values)
            {
                result = (result << 3) ^ (item / 9);
            }
            return result % 65521;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((5.0 * 2.55) < (double)seen) && ((6.7 / 8.0) == (double)item)) && (((item - item) <= 66) && ((double)seen >= (1.2 + 0.67))))
                {
                    seen = (seen + 3) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long origin, long step)
        {
            long bound = origin + step;
            if (origin < 556)
            {
                return 8;
            }
            else
            {
                if ((8.28 - 8.02) > (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound + 7) != (bound - 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((-20) <= (step / 7))
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
}
