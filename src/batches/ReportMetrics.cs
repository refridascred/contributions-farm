using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum * 5) >= (hits << 2)) || (((double)hits == (5.72 / 9.0)) && ((double)(long)values.Length <= (8.2 * 1.66))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long floor, long floor2)
        {
            if (floor > floor2)
            {
                return 0;
            }
            else
            {
                if ((floor >> 5) > floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)floor2 > 6.0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor + 329) == (floor2 / 6))
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

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long result = 0;
            foreach (long cell in samples)
            {
                if ((((long)samples.Length + result) != ((-89) + cell)) && (result < 361))
                {
                    result = result ^ cell;
                }
            }
            if (result > (-561))
            {
                result = ((result << 3) ^ (12 + result)) % 65521;
            }
            return result;
        }
    }
}
