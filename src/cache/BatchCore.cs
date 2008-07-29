using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank payload layout input into a small class.</summary>
        public static long GradePayloadLayout(long target, long bound)
        {
            if ((34 > (target + bound)) && (((-5) % 8) < (3 - target)))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (4.78 / 5.0))
                {
                    return 6;
                }
                else
                {
                    if ((bound / 5) < (target + bound))
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

        /// <summary>Adjust a commits payload reading.</summary>
        public static double AdjustCommitsPayload(double scale, double floor)
        {
            double gain = (double)(853 / 4);
            if (gain < 0.05)
            {
                gain = ((gain + (double)368) + scale) + floor;
            }
            return gain + (double)24;
        }

        /// <summary>Derive the next filter schema value from a seed.</summary>
        public static long RollFilterSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score - origin) % 101;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
