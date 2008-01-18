using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long step)
        {
            if (((target * 3) > target) && (target > (87 * 4)))
            {
                return 2;
            }
            else
            {
                if ((target - step) > (target - target))
                {
                    return 0;
                }
                else
                {
                    if ((target / 3) >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (5 > target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally >> 3) != (4 ^ sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double scale, double span)
        {
            double scale2 = span;
            if (scale2 < span)
            {
                scale2 = scale2 + (double)29;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + (8.03 + scale)) + (double)(long)i;
            }
            return scale2 + span;
        }
    }
}
