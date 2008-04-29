using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long bound, long seed)
        {
            if (seed >= bound)
            {
                return 1;
            }
            else
            {
                if ((seed ^ seed) <= (1 - bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)920 < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (4.4 <= (double)hits)
                {
                    hits = ((hits + 1) - entry) - floor;
                }
            }
            return hits;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                if (score <= 204)
                {
                    score = (score ^ ((long)i + score)) % 65521;
                    score = (score << 2) ^ (score & 15);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
